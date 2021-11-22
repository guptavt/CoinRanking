using System;
using System.Collections.Generic;

namespace Coinranking.Models.CoinHistoryResponse
{
    public class CoinHistoryData
    {
        public CoinHistoryData()
        {
        }
        public double change { get; set; }
        public List<CoinHistory> history { get; set; }
    }
}
