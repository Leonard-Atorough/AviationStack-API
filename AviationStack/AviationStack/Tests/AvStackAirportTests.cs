using System;
using NUnit.Framework;

namespace AviationStack
{
    public class AvStackAirportTests
    {
        private AvStackAirportService _avStackAirport = new AvStackAirportService();

        [Test]
        public void CheckCountIs100()
        {
            Assert.That(_avStackAirport.AvStackAirportDTO.Airports.pagination.count, Is.EqualTo(100));
        }
    }
}
