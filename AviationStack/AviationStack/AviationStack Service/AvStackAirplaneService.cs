using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using AviationStack.AvStackAirplane;

namespace AviationStack
{
    class AvStackAirplaneService
    {
        public string Airplanes { get; set; }

        public JObject Json_Airplanes { get; set; }

        public AvStackAirplaneManager AvStackAirplaneManager { get; set; } = new AvStackAirplaneManager();

        public AvStackAirplaneDTO AvStackAirplaneDTO { get; set; } = new AvStackAirplaneDTO();

        public int AirplaneCount()
        {
            var count = Json_Airplanes["pagination"]["count"].ToString();
            var intCount = Int32.Parse(count);
            return intCount;
        }

        public AvStackAirplaneService()
        {
            Airplanes = AvStackAirplaneManager.GetAirplanes();

            Json_Airplanes = JsonConvert.DeserializeObject<JObject>(Airplanes);

            AvStackAirplaneDTO.DeserializeAirplanes(Airplanes);
        }
    }
}
