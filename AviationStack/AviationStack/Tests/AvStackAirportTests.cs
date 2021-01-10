using System;
using NUnit.Framework;
//using AviationStack.AvStackAirport;

namespace AviationStack
{
    public class AvStackAirportTests
    {
        private AvStackAirportService _avStackAirport = new AvStackAirportService();

        [Test]
        public void CheckCountIs100()
        {
            Assert.That(_avStackAirport.AirportCount, Is.EqualTo("100"));
        }

        [Test]
        public void CheckTotalIs6471()
        {
            Assert.That(_avStackAirport.AirportTotal, Is.EqualTo("6471"));
        }

        [Test]
        public void CheckCorrectICAOCodeReturned()
        {
            Assert.That(_avStackAirport.AirportICAO, Does.Contain("NTGA"));
        }

        [Test]
        public void CheckCorrectIATACodeReturned()
        {
            Assert.That(_avStackAirport.AirportIATA, Does.Contain("AAA"));
        }

        [Test]
        public void CheckCorrectGeoNameIDReturned()
        {
            Assert.That(_avStackAirport.AirportGeoNameID, Does.Contain("6947726"));
        }
    }
}
