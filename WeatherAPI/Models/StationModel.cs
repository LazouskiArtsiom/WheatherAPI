namespace WeatherAPI.Models
{
    public class StationModel
    {
        public double? Distance { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? UseCount { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public double? Quality { get; set; }
        public double? Contribution { get; set; }
    }
}
