using System.Collections.Generic;

namespace WeatherService.Api
{
    public class WeatherLogic
    {
        public IEnumerable<WeatherForecast> GetWeather()
        {
            // Typically this would have validation, mapping between models and entities etc

            var dataStore = new WeatherDataStore();
            return dataStore.GetWeather();
        }

    }
}
