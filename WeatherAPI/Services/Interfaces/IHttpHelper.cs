namespace WeatherAPI.Services.Interfaces
{
    public interface IHttpHelper
    {
        string CombineUrl(string uri, string apiGroup, string city, string unitGroup, string apiKey, string contentType);
    }
}
