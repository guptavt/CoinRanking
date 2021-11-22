using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Coinranking.Models.CoinHistoryResponse;
using Coinranking.Models.CoinsResponse;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace Coinranking.Features.Steps
{
    [Binding]
    public class CoinsHistorySteps
    {
        ScenarioContext scenarioContext;

        public CoinsHistorySteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Then("find coins history for (.*)")]
        public void ThenFindCoinHistoryFor(string duration)
        {
            List<CoinsResponse> coinsData = this.scenarioContext.Get<List<CoinsResponse>>("FilteredData");
            Dictionary<string, List<CoinHistory>> coinHistoryDetails = new Dictionary<string, List<CoinHistory>>();
            coinsData.ForEach(coin =>
            {
                string url = "/coin/" + coin.id + "/history/7d";
                IRestResponse coinHistoryResponse = new HttpHelper().ExecuteRequest(url, Method.GET);
                if (coinHistoryResponse != null)
                {
                    Assert.IsTrue(coinHistoryResponse.IsSuccessful, "Request failed");
                    CoinHistoryGETResponse response = Utils.DeserialiseResponse<CoinHistoryGETResponse>(coinHistoryResponse);
                    Assert.IsTrue(response.status.Equals("success"), "status is wrong");
                    List<CoinHistory> histories = response.data.history;
                    histories = histories
                    .OrderBy(history => history.timestamp)
                    .ToList();
                    coinHistoryDetails.Add(coin.name, histories);
                }
            });
            this.scenarioContext.Set(coinHistoryDetails, "CoinHistoryDetails");
        }

        [Then("print each coin oldest and most recent history")]
        public void ThenPrintEachCoinOldestAndMostRecentHistory()
        {
            Dictionary<string, List<CoinHistory>> coinHistoryDetails = this.scenarioContext.Get<Dictionary<string, List<CoinHistory>>>("CoinHistoryDetails");
            foreach (KeyValuePair<string, List<CoinHistory>> entry in coinHistoryDetails)
            {
                string coinName = entry.Key;
                CoinHistory firstDataForTimeDuration = entry.Value[0];
                CoinHistory mostRecentDataForTimeDuration = entry.Value[entry.Value.Count - 1];
                Console.WriteLine("\nCoin = " + coinName);
                Console.WriteLine("\rFirst result in 7 days:\rPrice = $" + firstDataForTimeDuration.price + "\rTime = " + Utils.humanizeDateTime(firstDataForTimeDuration.timestamp));
                Console.WriteLine("\rMost recent result:\rPrice = $" + mostRecentDataForTimeDuration.price + "\rTime = " + Utils.humanizeDateTime(mostRecentDataForTimeDuration.timestamp));
            }
        }
    }
}
