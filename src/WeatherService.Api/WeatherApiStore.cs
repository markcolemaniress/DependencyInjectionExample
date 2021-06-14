using System;
using System.Collections.Generic;
using System.Linq;
using WeatherService.Api.Interfaces;

namespace WeatherService.Api
{
    public class WeatherApiStore : IWeatherDataStore
    {
        private static readonly string[] Summaries = new[]
        {
            "Brass Monkeys", "Hot as hell"
        };

        public IEnumerable<WeatherForecast> GetWeather()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();

        }
    }
}
