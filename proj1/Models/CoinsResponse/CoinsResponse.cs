using System;
using System.Collections.Generic;

namespace Coinranking.Models.CoinsResponse
{
    public class CoinsResponse
    {
        public CoinsResponse()
        {
        }
        public int id { get; set; }
        public string uuid { get; set; }
        public string slug { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public long volume { get; set; }
        public long marketCap { get; set; }
        public long firstSeen { get; set; }
        public long listedAt { get; set; }
        public int rank { get; set; }
        public double price { get; set; }
        public bool penalty { get; set; }
        public List<string> history { get; set; }
        
    }
}
