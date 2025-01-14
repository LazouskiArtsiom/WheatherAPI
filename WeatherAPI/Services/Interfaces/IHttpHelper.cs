using WeatherAPI.Models.Constants;

namespace WeatherAPI.Services.Interfaces
{
    public interface IHttpHelper
    {
        public string CombineCityWeatherUrl(
           string uri,
           string city,
           string apiKey,
           string apiGroup = UrlConstants.Timeline,
           string unitGroup = UrlConstants.Metric,
           string contentType = UrlConstants.Json);
    }
}
