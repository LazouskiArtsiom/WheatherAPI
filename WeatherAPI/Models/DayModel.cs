namespace WeatherAPI.Models
{
    public class DayModel
    {
        public string Datetime { get; set; }
        public long DatetimeEpoch { get; set; }
        public double? Tempmax { get; set; }
        public double? Tempmin { get; set; }
        public double? Temp { get; set; }
        public double? Feelslikemax { get; set; }
        public double? Feelslikemin { get; set; }
        public double? Feelslike { get; set; }
        public double? Dew { get; set; }
        public double? Humidity { get; set; }
        public double? Precip { get; set; }
        public double? Precipprob { get; set; }
        public double? Precipcover { get; set; }
        public List<string> Preciptype { get; set; }
        public double? Snow { get; set; }
        public double? Snowdepth { get; set; }
        public double? Windgust { get; set; }
        public double? Windspeed { get; set; }
        public double? Winddir { get; set; }
        public double? Pressure { get; set; }
        public double? Cloudcover { get; set; }
        public double? Visibility { get; set; }
        public double? Solarradiation { get; set; }
        public double? Solarenergy { get; set; }
        public double? Uvindex { get; set; }
        public double? Severerisk { get; set; }
        public string Sunrise { get; set; }
        public long SunriseEpoch { get; set; }
        public string Sunset { get; set; }
        public long SunsetEpoch { get; set; }
        public double? Moonphase { get; set; }
        public string Conditions { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public List<string> Stations { get; set; }
        public string Source { get; set; }
        public List<HourModel> Hours { get; set; }
        public double? Precipsum { get; set; }
        public double? Precipsumnormal { get; set; }
        public double? Snowsum { get; set; }
        public string DatetimeInstance { get; set; }
    }
}
