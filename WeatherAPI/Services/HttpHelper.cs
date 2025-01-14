using WeatherAPI.Models.Constants;
using WeatherAPI.Services.Interfaces;

namespace WeatherAPI.Services
{
    public class HttpHelper : IHttpHelper
    {
        public string CombineCityWeatherUrl(
            string uri, 
            string city,
            string apiKey,
            string apiGroup,
            string unitGroup,
            string contentType)
        {
            return $"{uri}{apiGroup}/{city}?{UrlConstants.UnitGroup}={unitGroup}&{UrlConstants.Key}={apiKey}&{UrlConstants.ContentType}={contentType}";
        }
    }
}
