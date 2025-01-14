namespace WeatherAPI.Models
{
    public class CurrentConditionsModel
    {
        public string Datetime { get; set; }
        public long DatetimeEpoch { get; set; }
        public double? Temp { get; set; }
        public double? Feelslike { get; set; }
        public double? Humidity { get; set; }
        public double? Dew { get; set; }
        public double? Precip { get; set; }
        public double? Precipprob { get; set; }
        public double? Snow { get; set; }
        public double? Snowdepth { get; set; }
        public List<string> Preciptype { get; set; }
        public double? Windgust { get; set; }
        public double? Windspeed { get; set; }
        public double? Winddir { get; set; }
        public double? Pressure { get; set; }
        public double? Visibility { get; set; }
        public double? Cloudcover { get; set; }
        public double? Solarradiation { get; set; }
        public double? Solarenergy { get; set; }
        public double? Uvindex { get; set; }
        public string Conditions { get; set; }
        public string Icon { get; set; }
        public List<string> Stations { get; set; }
        public string Source { get; set; }
        public string Sunrise { get; set; }
        public long SunriseEpoch { get; set; }
        public string Sunset { get; set; }
        public long SunsetEpoch { get; set; }
        public double? Moonphase { get; set; }
    }
}
