using System;
namespace Coinranking.Models.CoinsResponse
{
    public class CoinsGETResponse
    {
        public CoinsGETResponse()
        {
        }

        public string status { get; set; }
        public CoinsDataResponse data { get; set; }
    }
}
