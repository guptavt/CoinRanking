using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coinranking.Models.ExchangesResponse
{
    public class ExchangesDataResponse
    {
        public ExchangesDataResponse()
        {
        }
        public ExchangesStatsResponse exchangeStats { get; set; }
        [JsonProperty("base")]
        public List<ExchangesCurrenciesResponse> exchangesCurrencies { get; set; }
        public List<ExchangesResponse> exchanges { get; set; }
    }
}
