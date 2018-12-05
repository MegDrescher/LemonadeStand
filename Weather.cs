using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public int currentTemperature;
        public int predictedTemperature;
        public string predictedWeather;
        public int predictedWeatherIndex;
        public List<string> weatherVariables = new List<string>() { "Sunny and Hot!", "Cloudy and Cold!", "Sunny and Clear Skies!", "Rainy Day" };        
        public string currentWeatherCondition;
        public string weatherCondition;
        private readonly Random random;

        public Weather(Random rnd, Day day)
        {
        }

        public Weather(decimal minTemperature, decimal maxTemperature, Random random)
        {   
            this.random = random;
            predictedTemperature = random.Next(Decimal.ToInt32(minTemperature), Decimal.ToInt32(maxTemperature + 1));
            predictedWeatherIndex = random.Next(0, 3);

            predictedWeather = weatherVariables[predictedWeatherIndex];
        }

        public Weather(Random rnd)
        {
        }
    } 
}
