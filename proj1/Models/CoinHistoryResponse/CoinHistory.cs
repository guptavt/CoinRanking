using System;
namespace Coinranking.Models.CoinHistoryResponse
{
    public class CoinHistory
    {
        public CoinHistory()
        {
        }
        public string price { get; set; }
        public long timestamp { get; set; }
    }
}
