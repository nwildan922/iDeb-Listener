using Newtonsoft.Json;
using RabbitMQReiverCoreAPI.Helper;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQReiverCoreAPI.RebbitMQ
{
    public static class IDebHelper
    {
        private static RestClient _client = new RestClient();
        private static Uri BaseURL = new Uri(DataConfiguration.Configuration.AppConfiguration.ApiServerUrlReadFile);

        public static void RegisterFilname(string fileName)
        {
            var jsonString = JsonConvert.SerializeObject(new FileJson { JsonString = fileName });
            _client.BaseUrl = new Uri(String.Format("{0}{1}", BaseURL, "api/ReadFile/Save")); //  ke endpoint readfile
            var requests = new RestRequest(Method.POST);

            requests.AddParameter("application/json", jsonString, ParameterType.RequestBody);

            _client.Execute(requests);

        }
    }
}
