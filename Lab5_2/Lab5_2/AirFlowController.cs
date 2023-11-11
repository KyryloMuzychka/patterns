using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    public class AirFlowController
    {
        public AirFlowMeter flowMeter;
        private int normalAirFlow;

        public AirFlowController()
        {
            flowMeter = new AirFlowMeter();
            normalAirFlow = 140;
        }

        public string TakeAir()
        {
            int airMeasurement = flowMeter.GetMeasurements();
            int difference = normalAirFlow - airMeasurement;
            if (airMeasurement < normalAirFlow)
                return $"Air taken. Difference: {difference} cubic meters per second.";
            else if (airMeasurement > normalAirFlow)
                return $"Limited air flow. Difference: {difference} cubic meters per second.";
            return $"No need for taking air. Difference: {difference} cubic meters per second.";
        }

        public string Off()
        {
            return "Airflow controller turned off.";
        }
    }
}
