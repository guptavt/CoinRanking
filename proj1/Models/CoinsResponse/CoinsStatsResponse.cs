using System;
namespace Coinranking.Models.CoinsResponse
{
    public class CoinsStatsResponse
    {
        public CoinsStatsResponse()
        {
        }
        public int total { get; set; }
        public string order { get; set; }
        public string baseAttribute { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public int totalMarkets { get; set; }
        public int totalExchanges { get; set; }
        public double totalMarketCap { get; set; }
        public double total24hVolume { get; set; }

    }
}
