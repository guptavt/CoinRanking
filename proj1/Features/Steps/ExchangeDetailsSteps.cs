using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Coinranking.Models.ExchangesResponse;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;
using TechTalk.SpecFlow;

namespace Coinranking.Features.Steps
{
    [Binding]
    public class ExchangeDetailsSteps
    {
        ScenarioContext scenarioContext;
        public ExchangeDetailsSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Then("print exchange details order by (.*) on (.*)")]
        public void ThenPrintExchangeDetailsOrderBy(string sortOrder, string sortByField)
        {
            List<ExchangesResponse> filteredData = this.scenarioContext.Get<List<ExchangesResponse>>("FilteredData");// get the list of exchange to print details
            if (sortOrder.Equals("Descending"))
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
            ExchangesGETResponse exchangesGETResponse = Utils.DeserialiseResponse<ExchangesGETResponse>(response);
            filteredData.ForEach(exchange =>
            {
                Console.WriteLine("\nName = " + exchange.name + "\rNumber of markets = " + exchange.numberOfMarkets + "\rVolume = " + exchange.volume + "\rRank = " + exchange.rank);
            }); // print exchange details on console
        }
    }
}
