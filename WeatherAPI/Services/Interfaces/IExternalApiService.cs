using WeatherAPI.Models;

namespace WeatherAPI.Services.Interfaces
{
    public interface IExternalApiService
    {
        Task<WeatherModel> GetCityWeather(string city);
    }
}
