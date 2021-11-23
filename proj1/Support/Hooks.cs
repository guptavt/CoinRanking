using Coinranking.Models.CoinsResponse;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Coinranking.Support
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext scenarioContext;
        public Hooks(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }
      
        [AfterScenario()]
        public void AfterCommonSteps()
        {
            this.scenarioContext.TryGetValue("RequestResource", out string requestResource);
            IRestResponse RawResponse = this.scenarioContext.Get<IRestResponse>("RawResponse");
            this.scenarioContext.TryGetValue("FilteredData", out var FilteredData);

            if (requestResource != null)
            {
                this.scenarioContext.Remove("RequestResource");
            }
            if (RawResponse != null)
            {
                this.scenarioContext.Remove("RawResponse");
            }
            if (FilteredData != null)
            {
                this.scenarioContext.Remove("FilteredData");
            }           
        }

        [AfterScenario("CoinHistory")]
        public void AfterCoins()
        {
            this.scenarioContext.TryGetValue("coinHistoryDetails", out string coinHistoryDetails);
            if (coinHistoryDetails != null)
            {
                this.scenarioContext.Remove("coinHistoryDetails");
            }
        }
    }
}
