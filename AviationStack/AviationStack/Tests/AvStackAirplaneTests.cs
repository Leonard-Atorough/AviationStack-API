using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AviationStack
{

    class AvStackAirplaneTests
    {
        AvStackAirplaneService _avStackAirplaneService = new AvStackAirplaneService();

        [Test]
        public void ApiCallReturnsExpectedNumberOfResults()
        {
            Assert.That((_avStackAirplaneService.AirplaneCount()), Is.EqualTo(100));
        }
    }
}
