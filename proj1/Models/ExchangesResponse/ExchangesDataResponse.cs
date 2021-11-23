using System;
using Newtonsoft.Json;
using System.Collections.Generic;


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
