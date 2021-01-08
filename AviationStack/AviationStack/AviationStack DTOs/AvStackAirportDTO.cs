using Newtonsoft.Json;

namespace AviationStack
{
    public class AvStackAirportDTO
    {
        public AirportRoot Airports { get; set; }

        public void DeserialiseAirports (string airportsResponse)
        {
            Airports = JsonConvert.DeserializeObject<AirportRoot>(airportsResponse);
        }
    }
}
