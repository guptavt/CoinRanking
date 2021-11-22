using System;
using System.Collections.Generic;
using System.Linq;
using Coinranking.Models.CoinsResponse;
using Coinranking.Models.ExchangesResponse;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace Coinranking
{
    [Binding]
    public class CoinsDetailsSteps
    {
        ScenarioContext scenarioContext;

        public CoinsDetailsSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Then("print coin details order by (.*) on (.*)")]
        public void ThenPrintCoinDetailsOrderBy(string sortOrder, string sortByField)
        {
            List<CoinsResponse> filteredData = this.scenarioContext.Get<List<CoinsResponse>>("FilteredData");
            if (sortOrder.Equals("DSC"))
            {
                filteredData = filteredData
                .OrderByDescending(coin => coin.GetType().GetProperty(sortByField).GetValue(coin, null)).ToList();
            }
            else
            {
                filteredData = filteredData
                .OrderBy(coin => coin.GetType().GetProperty(sortByField).GetValue(coin, null)).ToList();
            }

            IRestResponse response = this.scenarioContext.Get<IRestResponse>("RawResponse");
            CoinsGETResponse coinsGETResponse = Utils.DeserialiseResponse<CoinsGETResponse>(response);
            filteredData.ForEach(coin =>
            {
                string firstseen = "NA";
                firstseen = Utils.humanizeDateTime(coin.firstSeen);
                Console.WriteLine("\nName = " + coin.name + "\rType = " + coin.type + "\rRank = " + coin.rank + "\rFirst Seen = " + firstseen + "\rPrice = " + coinsGETResponse.data.baseAttribute.sign + coin.price + "\n");
            });
        }
    }
}
