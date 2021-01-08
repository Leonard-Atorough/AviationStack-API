using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AviationStack
{
    class AvStackAirplaneService
    {
        public string Airplanes { get; set; }

        public JObject Json_Airplanes { get; set; }

        public AvStackAirplaneManager AvStackAirplaneManager { get; set; }

        public AvStackAirplaneDTO AvStackAirplaneDTO { get; set; }

        public AvStackAirplaneService()
        {
            Airplanes = AvStackAirplaneManager.GetAirplanes();

            Json_Airplanes = JsonConvert.DeserializeObject<JObject>(Airplanes);


        }
    }
}
