using System;
using Newtonsoft.Json;
using RestSharp;

namespace Coinranking
{
    public class Utils
    {
        public Utils()
        {
            
        }

        public static T DeserialiseResponse<T>(IRestResponse response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public static string humanizeDateTime(long unixMilis)
        {
            DateTimeOffset dto = DateTimeOffset.FromUnixTimeMilliseconds(unixMilis);
            return dto.UtcDateTime.ToLongDateString();
        }
    }
}
