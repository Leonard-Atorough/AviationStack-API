using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace AviationStack
{
    class AvStackAirplaneManager
    {
        private static IRestClient _client;

        public AvStackAirplaneManager()
        {
            _client = new RestClient(AvStackConfigReader.BaseUrl);
        }

        public string GetAirplanes()
        {
            var request = new RestRequest("/airplanes" + AvStackConfigReader.ApiUrlMod + AvStackConfigReader.ApiKey, Method.GET);
            var response = _client.Execute(request);

            return response.Content;
        }

        public string GetGivenNumberOfAirplanes(JObject numberOfPlanes)
        {
            //var request = new RestRequest("/airplanes" + AvStackConfigReader.ApiUrlMod + AvStackConfigReader.ApiKey, Method.GET);
            //request.AddParameter("count", numberOfPlanes.ToString());
            //var response = _client.Execute(request);

            //return response.Content;
            throw new NotImplementedException();
        }
    }
}
