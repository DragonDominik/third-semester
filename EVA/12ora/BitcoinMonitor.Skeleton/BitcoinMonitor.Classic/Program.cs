using ELTE.BitcoinMonitor.Model;
using System.Timers;

namespace BitcoinMonitor.Classic
{
    internal class Program
    {
        private static decimal? _lastRate = null;
        private static decimal? _lastMax = null;

        static void Main(string[] args)
        {
            var timer = new System.Timers.Timer(5_000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            Console.WriteLine("Press any key to close the application");
            Console.ReadKey();
        }

        private static async void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            var rate = await BitcoinRateFetcher.Fetch();
            if (!rate.HasValue) {
                return;
            }

            if (!_lastRate.HasValue || !_lastMax.HasValue)
            {
                _lastRate = rate;
                _lastMax = rate;
            }
            else if (_lastRate.Value == rate.Value)
            {
                return;
            }

            _lastRate = rate;

            if (!_lastMax.HasValue || _lastMax.Value < rate.Value)
            {
                _lastMax = rate;
                Console.WriteLine($"New maximum value {_lastMax.Value}");
            }

                var rateInt = Convert.ToInt32(rate.Value);
            Console.WriteLine($"Bitcoin to EUR: {rateInt} EUR | Highest Rate: {Convert.ToInt32(_lastMax.Value)}");
        }
    }
}
