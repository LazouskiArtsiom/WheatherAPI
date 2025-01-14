using static System.Collections.Specialized.BitVector32;

namespace WeatherAPI.Models
{
    public class WeatherModel
    {
        public int QueryCost { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string ResolvedAddress { get; set; }
        public string Address { get; set; }
        public string Timezone { get; set; }
        public double? Tzoffset { get; set; }
        public string Description { get; set; }
        public List<DayModel> Days { get; set; }
        public Dictionary<string, StationModel> Stations { get; set; }
        public CurrentConditionsModel CurrentConditions { get; set; }
    }
}
