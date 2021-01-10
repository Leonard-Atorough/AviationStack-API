using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Newtonsoft.Json.Linq;

namespace AviationStack
{

    class AvStackAirplaneTests
    {
        AvStackAirplaneService _avStackAirplaneService = new AvStackAirplaneService();

        [Test]
        public void ApiCallReturnsExpectedNumberOfResults()
        {
            Assert.That(_avStackAirplaneService.AirplaneCount(), Is.EqualTo(100));
        }

        [Test]
        public void ApiCallReturnsExpectedTotalResults()
        {
            Assert.That(_avStackAirplaneService.AirplaneTotal(), Is.EqualTo(19052));
        }

        [Test]
        public void ProductionLineExists()
        {
            string productionItem = "Boeing 737 Classic";

            Assert.That(_avStackAirplaneService.FindProductionLine(productionItem));
        }
    }
}
