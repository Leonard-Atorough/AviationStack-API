using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AviationStack
{
    public class AvStackAirportService
    {
        public AvStackAirportManager AvStackAirportManager { get; set; } = new AvStackAirportManager();

        public AvStackAirportDTO AvStackAirportDTO { get; set; } = new AvStackAirportDTO();

        public string Airports { get; set; }

        public JObject Json_airports { get; set; }


        public AvStackAirportService()
        {
            Airports = AvStackAirportManager.GetAirportData();

            Json_airports = JsonConvert.DeserializeObject<JObject>(Airports);

            AvStackAirportDTO.DeserialiseAirports(Airports);
        }
    }
}
