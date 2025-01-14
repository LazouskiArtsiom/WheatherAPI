using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Services.Interfaces;

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IExternalApiService _externalApiService;

        public WeatherController(IExternalApiService externalApiService)
        {
            _externalApiService = externalApiService;
        }

        [HttpGet("city")]
        public async Task<IActionResult> GetCityWeather([FromQuery] string city)
        {
            var result = await _externalApiService.GetCityWeather(city);
            return Ok(result);
        }
    }
}
