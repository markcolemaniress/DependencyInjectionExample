using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WeatherService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var logic = new WeatherLogic();
            return logic.GetWeather();
        }
    }
}
