using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Services.Interfaces;

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyController : ControllerBase
    {
        private readonly IExternalApiService _externalApiService;

        public MyController(IExternalApiService externalApiService)
        {
            _externalApiService = externalApiService;
        }

        [HttpGet("test")]
        public async Task<IActionResult> Test()
        {
            var result = await _externalApiService.CallEzternalApi();
            return Ok(result);
        }
    }
}
