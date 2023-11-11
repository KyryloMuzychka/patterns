using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    public class Radiator
    {
        public string On(int speed)
        {
            return SetSpeed(speed) + $"Radiator turned on.";
        }

        public string Off()
        {
            return "Radiator turned off.";
        }

        public string SetSpeed(int speed)
        {
            return $"Radiator speed set to {speed}.\n";
        }
    }
}
