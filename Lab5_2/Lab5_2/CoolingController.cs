using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    public class CoolingController
    {
        public Radiator radiator;
        public TemperatureSensor temperatureSensor;
        public int temperatureUpperLimit;

        public CoolingController()
        {
            radiator = new Radiator();
            temperatureSensor = new TemperatureSensor();
            SetTemperatureUpperLimit(90);
        }

        public void SetTemperatureUpperLimit(int temperatureLimit)
        {
            temperatureUpperLimit = temperatureLimit;
        }

        public string Run(int currentTemperature)
        {
            string message = "No need for cooling.";
            if (currentTemperature > temperatureUpperLimit)
            {
                if (currentTemperature - temperatureUpperLimit > 30)
                    message = Cool(3000);
                else if (currentTemperature - temperatureUpperLimit > 15)
                    message = Cool(2000);
                else
                    message = Cool(1000);
                while (currentTemperature > temperatureUpperLimit)
                {
                    currentTemperature--;
                }
            }
            return message;
        }

        private string Cool(int speed)
        {
            return radiator.On(speed) + "\nCooling system activated.";
        }

        public string Stop()
        {
            return radiator.Off() + "\nCooling system stopped.";
        }
    }
}
