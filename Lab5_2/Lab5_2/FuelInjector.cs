using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    public class FuelInjector
    {
        public FuelPump fuelPump;

        public FuelInjector()
        {
            fuelPump = new FuelPump();
        }

        public string On()
        {
            return fuelPump.Pump() + " And fuel injector turned on.\n" + Inject();
        }

        public string Inject()
        {
            return "Fuel injected into the engine.";
        }

        public string Off()
        {
            return "Fuel injector turned off.";
        }
    }
}
