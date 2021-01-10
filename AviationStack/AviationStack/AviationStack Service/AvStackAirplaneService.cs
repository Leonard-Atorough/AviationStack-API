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
            return Int32.Parse(count);
            
        }

        public int AirplaneTotal()
        {
            var total = Json_Airplanes["pagination"]["total"].ToString();
            return Int32.Parse(total);

        }

        public bool FindProductionLine(string productionLine)
        {
            return Json_Airplanes["data"][0]["production_line"].ToString() == productionLine;
        }

        public AvStackAirplaneService()
        {
            Airplanes = AvStackAirplaneManager.GetAirplanes();

            Json_Airplanes = JsonConvert.DeserializeObject<JObject>(Airplanes);

            AvStackAirplaneDTO.DeserializeAirplanes(Airplanes);
        }
    }
}
