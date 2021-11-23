using System;
using Coinranking.Models.CoinsResponse;
using Coinranking.Models.ExchangesResponse;
using Coinranking;
using NUnit.Framework;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace Coinranking.Features.Steps
{
    [Binding]
    public class CommonSteps
    {
        ScenarioContext scenarioContext;

        public CommonSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Given("(.*) request")]
        public void GivenRequest(string resource)
        {
            this.scenarioContext.Set(resource, "RequestResource");
        }

        [When("(.*) request is executed")]
        public void WhenRequestIsExecuted(string method)
        {
            Method requestMethod = Method.OPTIONS;
            switch (method)
            {
                case "GET":
                    requestMethod = Method.GET;
                    break;
            }
            string url = this.scenarioContext.Get<string>("RequestResource");
            IRestResponse response = new HttpHelper().ExecuteRequest(url, requestMethod);
            Assert.IsTrue(response.IsSuccessful,
                String.Format("Request {0} failed.Http Status code received = {1}", url, response.StatusCode));
            this.scenarioContext.Set<IRestResponse>(response, "RawResponse"); // set the response in context
        }

        [Then("find (.*) matching (.*)")]
        public void ThenFindMatching(string propertyToFilter, string filter)
        {
            List<string> filterValues = new List<string>();
            IRestResponse response = this.scenarioContext.Get<IRestResponse>("RawResponse");
            if (filter != null)
            {
                filterValues = filter.Trim().Split(',').ToList(); // retrieve the coins/exchanges
            }
            if (response != null)
            {
                if (propertyToFilter.Equals("coins"))// Retrieve coin details from response & store in context
                {
                    CoinsGETResponse coinsGETResponse = Utils.DeserialiseResponse<CoinsGETResponse>(response);
                    var coins = coinsGETResponse.data.coins;
                    List<CoinsResponse> filteredData = coins.Where(coin => filterValues.Contains(coin.name)).ToList();
                    this.scenarioContext.Set(filteredData, "FilteredData"); 
                }
                else if (propertyToFilter.Equals("exchanges"))// Retrieve exchange details from response & store in context
                {
                    ExchangesGETResponse exchangeGETResponse = Utils.DeserialiseResponse<ExchangesGETResponse>(response);
                    var exchanges = exchangeGETResponse.data.exchanges;
                    List<ExchangesResponse> filteredData = exchanges.Where(exchange => filterValues.Contains(exchange.name)).ToList();
                    this.scenarioContext.Set(filteredData, "FilteredData");
                }
              
            }
        }
    }
}
