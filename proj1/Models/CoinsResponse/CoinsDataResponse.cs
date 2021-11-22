using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinranking.Models.CoinsResponse
{
    public class CoinsDataResponse
    {
        public CoinsDataResponse()
        {
        }

        public CoinsStatsResponse stats { get; set; }
        [JsonProperty("base")]
        public CoinsBaseResponse baseAttribute {get; set;}
        public List<CoinsResponse> coins { get; set; }
    }
}
