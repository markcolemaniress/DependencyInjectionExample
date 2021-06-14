using System.Collections.Generic;
using WeatherService.Api.Interfaces;

namespace WeatherService.Api
{
    public class WeatherLogic : IWeatherLogic
    {
        private readonly IWeatherDataStore dataStore;

        public WeatherLogic()
        {
            dataStore = new WeatherDataStore();
        }

        public WeatherLogic(IWeatherDataStore weatherDataStore)
        {
            dataStore = weatherDataStore;
        }

        public IEnumerable<WeatherForecast> GetWeather()
        {
            // Typically this would have validation, mapping between models and entities etc

            return dataStore.GetWeather();
        }

    }
}
