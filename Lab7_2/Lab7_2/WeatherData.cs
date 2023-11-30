using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void registerObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            int i = observers.IndexOf(observer);
            if (i >= 0)
            {
                observers.Remove(observer);
            }
        }

        public void notifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                IObserver observer = (IObserver)observers[i];
                observer.update(temperature, humidity, pressure);
            }
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }

        public float getTemperature()
        {
            return temperature;
        }

        public float getHumidity()
        {
            return humidity;
        }

        public float getPressure()
        {
            return pressure;
        }
    }
}
