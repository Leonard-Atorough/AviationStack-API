using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AviationStack.AvStackAirplane
{
    class AvStackAirplaneDTO
    {
        public AirplaneRoot Airplanes { get; set; }

        public void DeserializeAirplanes(string AirplanesResponse)
        {
            Airplanes = JsonConvert.DeserializeObject<AirplaneRoot>(AirplanesResponse);
        }
    }
}
