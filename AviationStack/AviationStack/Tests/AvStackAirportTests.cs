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


    }
}
