using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coinranking.Models.ExchangesResponse
{
    public class ExchangesCurrenciesResponse
    {
        public ExchangesCurrenciesResponse()
        {
        }
        public int id { get; set; }
        public string uuid { get; set; }
        public string type { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string sign { get; set; }

    }
}
