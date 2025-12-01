using System.Text.Json.Serialization;

namespace ELTE.BitcoinMonitor.Model
{
    /// <summary>
    /// Class to deserialize the API response
    /// </summary>
    internal class BitcoinResponse
    {
        [JsonPropertyName("symbol")]
        public required string Symbol { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }
    }
}
