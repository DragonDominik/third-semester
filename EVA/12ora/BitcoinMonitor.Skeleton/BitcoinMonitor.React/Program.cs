using ELTE.BitcoinMonitor.Model;
using System.Reactive.Linq;
using System.Timers;

namespace BitcoinMonitor.React
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bitcoinObservable =
                Observable.Interval(TimeSpan.FromSeconds(1))
                          .SelectMany(async _ => await BitcoinRateFetcher.Fetch())
                          .Publish()
                          .RefCount()
                          .Where(rate => rate.HasValue)
                          .Select(rate => rate.Va);

            var subscription = bitcoinObservable.Subscribe(
                rate => Console.WriteLine($"Bitcoin to EUR: {rate} EUR"),
                ex => Console.WriteLine($"Error: {ex.Message}"),
                () => Console.WriteLine("Monitoring completed.")
            );

            decimal? lastMax = null;

            var maxObserver = bitcoinObservable.Scan((decimal?)null, (max, rate) =>
            {
                if (rate == null) return null;
                if (lastMax == null || rate > lastMax)
                {
                    lastMax = rate;
                    return rate;
                }
                return null;
            });

            var maxSubscription = maxObserver.Subscribe(
                rate =>
                {
                    if (rate != null)
                    {
                        Console.WriteLine($"New max: {rate} EUR");
                    }
                },
                ex => Console.WriteLine($"Error: {ex.Message}"),
                () => Console.WriteLine("Max Monitoring completed.")
            );

            Console.ReadKey();
            subscription.Dispose();
            maxSubscription.Dispose();
        }


        static void Other()
        {
            var myObservable = Observable.Create<decimal?>(observer =>
            {
                var timer = new System.Timers.Timer(5_000);
                timer.Elapsed += async (s, e) =>
                {
                    try
                    {
                        var rate = await BitcoinRateFetcher.Fetch();
                        observer.OnNext(rate);
                    }
                    catch (Exception ex)
                    {
                        observer.OnError(ex);
                    }
                };

                timer.Start();

                return () => {
                    timer.Stop();
                    timer.Dispose();
                };
            });
            var subscription = myObservable.Subscribe(
                 onNext: rate => { Console.WriteLine($"Cur rate: {rate!.Value}"); },
                 onError: ex => Console.WriteLine($"Error: {ex.Message}")
             );

            Console.ReadKey();
            subscription.Dispose();
        }
    }
}
