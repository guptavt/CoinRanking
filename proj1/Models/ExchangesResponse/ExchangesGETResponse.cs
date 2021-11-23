using System;
using System.Collections.Generic;

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
