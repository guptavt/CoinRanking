using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coinranking.Models.ExchangesResponse
{
    public class ExchangesResponse
    {
        public ExchangesResponse()
        {
        }
        public int id { get; set; }
        public string uuid { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string iconUrl { get; set; }
        public bool verified { get; set; }
        public long lastTickerCreatedAt { get; set; }
        public int numberOfMarkets { get; set; }
        public long volume { get; set; }
        public string websiteUrl { get; set; }
        public int rank { get; set; }
        public double marketShare { get; set; }
       
    }
}
