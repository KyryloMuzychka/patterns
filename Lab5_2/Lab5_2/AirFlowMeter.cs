using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    public class AirFlowMeter
    {
        private int air;

        public int GetMeasurements()
        {
            return this.air;
        }

        public void SetMeasurements(int air)
        {
            this.air = air;
        }
    }
}
