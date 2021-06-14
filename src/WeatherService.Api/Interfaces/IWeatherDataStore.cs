using System.Collections.Generic;

namespace WeatherService.Api.Interfaces
{
    public interface IWeatherDataStore
    {
        IEnumerable<WeatherForecast> GetWeather();
    }
}
