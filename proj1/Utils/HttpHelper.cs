using System;
using System.Collections;
using NUnit.Framework;
using RestSharp;

namespace Coinranking
{
    public class HttpHelper
    {
        protected string baseUrl;

        public HttpHelper()
        {
            baseUrl = "https://coinranking1.p.rapidapi.com";
        }
        public IRestResponse ExecuteRequest(string resource, Method method )
        {
            IRestResponse response;
            var env = Environment.GetEnvironmentVariables();         
            string apiKey = Environment.GetEnvironmentVariable("API_KEY");
            Assert.NotNull(apiKey, "API key not found");
            RestClient client = new RestClient(baseUrl);
            IRestRequest request = new RestRequest(resource, method);
            request.AddHeader("x-rapidapi-host", "coinranking1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", apiKey);
            response = client.Execute(request);
            return response;
        }
    }
}


