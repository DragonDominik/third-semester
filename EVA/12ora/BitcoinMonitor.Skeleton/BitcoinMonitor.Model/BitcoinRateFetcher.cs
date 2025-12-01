using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ELTE.BitcoinMonitor.Model;

public static class BitcoinRateFetcher
{
    private const string ApiUrl = "https://api.binance.com/api/v3/ticker/price?symbol=BTCEUR";

    /// <summary>
    /// Method to fetch Bitcoin to EUR rate from Binance API
    /// </summary>
    /// <returns>Bitcoin to EUR rate</returns>
    public static async Task<decimal?> Fetch()
    {
        try
        {
            using var client = new HttpClient();
            var response = await client.GetFromJsonAsync<BitcoinResponse>(ApiUrl);
            return response?.Price;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to fetch data: {ex.Message}");
            return null;
        }
    }
}