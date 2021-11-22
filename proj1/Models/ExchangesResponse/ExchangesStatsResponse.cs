using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coinranking.Models.ExchangesResponse
{
   public class ExchangesStatsResponse
    {
        public ExchangesStatsResponse()
        {
        }
        public long volume { get; set; }
        public int total { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }        
    }
}
