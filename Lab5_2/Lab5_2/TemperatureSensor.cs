using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    public class TemperatureSensor
    {
        private int temperature;

        public int GetTemperature()
        {
            return temperature;
        }

        public void SetTemperature(int temp)
        {
            this.temperature = temp;
        }
    }
}
