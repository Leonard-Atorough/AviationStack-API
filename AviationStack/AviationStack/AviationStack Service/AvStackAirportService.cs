﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AviationStack.AvStackAirport;

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

        public string AirportCount()
        {
            return Json_airports["pagination"]["count"].ToString();
        }

        public string AirportTotal()
        {
            return Json_airports["pagination"]["total"].ToString();
        }
    }
}
