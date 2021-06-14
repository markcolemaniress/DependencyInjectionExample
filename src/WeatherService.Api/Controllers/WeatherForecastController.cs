using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WeatherService.Api.Interfaces;

namespace WeatherService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController()
        {
            WeatherLogic = new WeatherLogic();
        }

        public IWeatherLogic WeatherLogic { get; }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return WeatherLogic.GetWeather();
        }
    }
}
