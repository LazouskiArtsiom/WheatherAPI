using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using WeatherAPI.Models;
using WeatherAPI.Services.Interfaces;

namespace WeatherAPI.Services
{
    public class ExternalApiService : IExternalApiService
    {
        private readonly string _apiKey;
        private readonly string _uri;
        private IHttpHelper _httpHelper;
        private readonly HttpClient _httpClient;

        public ExternalApiService(
            IOptions<WeatherApiOptions> options, 
            IHttpHelper httpHelper, 
            HttpClient httpClient)
        {
            _apiKey = options.Value.ApiKey;
            _uri = options.Value.Uri;
            _httpHelper = httpHelper;
            _httpClient = httpClient;
        }

        public async Task<WeatherModel> GetCityWeather(string city)
        {
            try
            {
                var url = _httpHelper.CombineCityWeatherUrl(_uri, city, _apiKey);
                var response = await _httpClient.GetAsync(url);

                response.EnsureSuccessStatusCode();

                var responseJson = await response.Content.ReadAsStringAsync();

                var weatherResponse = JsonConvert.DeserializeObject<WeatherModel>(responseJson);

                return weatherResponse;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching weather data: {ex.Message}");
                throw;
            }
        }
    }
}
