using System;
namespace Coinranking.Models.CoinHistoryResponse
{
    public class CoinHistoryGETResponse
    {
        public CoinHistoryGETResponse()
        {
        }
        public string status { get; set; }
        public CoinHistoryData data { get; set; }
    }
}
