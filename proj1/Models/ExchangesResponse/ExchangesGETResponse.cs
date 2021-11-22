using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coinranking.Models.ExchangesResponse
{
    public class ExchangesGETResponse
    {
        public ExchangesGETResponse()
        {
        }
        public string status { get; set; }
        public ExchangesDataResponse data { get; set; }
    }
}
