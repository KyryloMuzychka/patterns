using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab7_2.ForecastDisplay;

namespace Lab7_2
{
    public class Data
    {
        public static string currentConditions;
        public static string temperature;
        public static string heatIndex;
        public static string displayWeather;

        public static WeatherData weatherData;

        public static CurrentConditionsDisplay currentDisplay;
        public static StatisticsDisplay statisticsDisplay;
        public static ForecastDisplay forecastDisplay;
        public static HeatIndexDisplay heatIndexDisplay;


        public static void CreateData()
        {
            weatherData = new WeatherData();
            currentDisplay = new CurrentConditionsDisplay(weatherData);
            statisticsDisplay = new StatisticsDisplay(weatherData);
            forecastDisplay = new ForecastDisplay(weatherData);
            heatIndexDisplay = new HeatIndexDisplay(weatherData);
        }
    }
}
