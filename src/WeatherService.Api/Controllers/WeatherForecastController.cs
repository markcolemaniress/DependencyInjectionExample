using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WeatherService.Api.Interfaces;

namespace WeatherService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherLogic logic;

        public WeatherForecastController(IWeatherLogic weatherLogic)
        {
            logic = weatherLogic;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return logic.GetWeather();
        }
    }
}
