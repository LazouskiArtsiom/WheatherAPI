using WeatherAPI.Models.Constants;
using WeatherAPI.Services.Interfaces;

namespace WeatherAPI.Services
{
    public class HttpHelper : IHttpHelper
    {
        public string CombineUrl(string uri, string apiGroup, string city, string unitGroup, string apiKey, string contentType)
        {
            return $"{uri}{apiGroup}/{city}?{UrlConstants.UnitGroup}={unitGroup}&{UrlConstants.Key}={apiKey}&{UrlConstants.ContentType}={contentType}";
        }
    }
}
