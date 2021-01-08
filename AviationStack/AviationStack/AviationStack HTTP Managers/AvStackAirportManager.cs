using System;
using RestSharp;

namespace AviationStack
{
    public class AvStackAirportManager
    {
        private readonly IRestClient _client;

        public AvStackAirportManager()
        {
            _client = new RestClient(AvStackConfigReader.BaseUrl);
        }

        public string GetAirportData()
        {
            var request = new RestRequest("airports" + AvStackConfigReader.ApiUrlMod + AvStackConfigReader.ApiKey);
            var response = _client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
