using System.Collections.Generic;

namespace WeatherService.Api.Interfaces
{
    public interface IWeatherLogic
    {
        IEnumerable<WeatherForecast> GetWeather();
    }
}
