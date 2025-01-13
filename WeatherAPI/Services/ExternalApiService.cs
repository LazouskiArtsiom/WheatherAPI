using Microsoft.Extensions.Options;
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

        public async Task<bool> CallEzternalApi()
        {   
            var url = $"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/Minsk?unitGroup=metric&key={_apiKey}&contentType=json";
            var response = await _httpClient.GetAsync(url);
            var body = response.Content.ReadAsStringAsync();

            return true;
        }
    }
}
