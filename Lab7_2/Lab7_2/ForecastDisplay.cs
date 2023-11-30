using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float currentPressure = 760.0f;
        private float lastPressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temp, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;

            display();
        }

        public void display()
        {
            Data.displayWeather = "Forecast: ";
            if (currentPressure > lastPressure)
            {
                Data.displayWeather += "Improving weather on the way!";
            }
            else if (currentPressure == lastPressure)
            {
                Data.displayWeather += "More of the same";
            }
            else if (currentPressure < lastPressure)
            {
                Data.displayWeather += "Watch out for cooler, rainy weather";
            }

        }

        public class HeatIndexDisplay : IObserver, IDisplayElement
        {
            double heatIndex = 0.0f;
            private WeatherData weatherData;

            public HeatIndexDisplay(WeatherData weatherData)
            {
                this.weatherData = weatherData;
                weatherData.registerObserver(this);
            }

            public void update(float t, float rh, float pressure)
            {
                heatIndex = computeHeatIndex(t, rh);
                display();
            }

            private static double CalculateHeatIndexFahrenheit(double temperatureFahrenheit, double relativeHumidity)
            {
                double c1 = -42.379;
                double c2 = 2.04901523;
                double c3 = 10.14333127;
                double c4 = -0.22475541;
                double c5 = -6.83783e-3;
                double c6 = -5.481717e-2;
                double c7 = 1.22874e-3;
                double c8 = 8.5282e-4;
                double c9 = -1.99e-6;

                double heatIndexFahrenheit = c1 + (c2 * temperatureFahrenheit) + (c3 * relativeHumidity)
                    + (c4 * temperatureFahrenheit * relativeHumidity) + (c5 * Math.Pow(temperatureFahrenheit, 2))
                    + (c6 * Math.Pow(relativeHumidity, 2)) + (c7 * Math.Pow(temperatureFahrenheit, 2) * relativeHumidity)
                    + (c8 * temperatureFahrenheit * Math.Pow(relativeHumidity, 2)) + (c9 * Math.Pow(temperatureFahrenheit, 2) * Math.Pow(relativeHumidity, 2));

                return heatIndexFahrenheit;
            }

            private double computeHeatIndex(double temperatureCelsius, double relativeHumidity)
            {
                double temperatureFahrenheit = (temperatureCelsius * 9 / 5) + 32;
                double heatIndexFahrenheit = CalculateHeatIndexFahrenheit(temperatureFahrenheit, relativeHumidity);
                double heatIndexCelsius = (heatIndexFahrenheit - 32) * 5 / 9;
                return heatIndexCelsius;
            }

            public void display()
            {
                Data.heatIndex = $"Heat index is {heatIndex}";
            }
        }
    }
}
