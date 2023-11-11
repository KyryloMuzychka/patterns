using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    public class CarCoolingSystemFacade
    {
        private CoolingController coolingController;
        private AirFlowController airFlowController;
        private FuelInjector fuelInjector;
        private Starter starter;
        private CatalyticConverter catalyticConverter;

        public CarCoolingSystemFacade()
        {
            coolingController = new CoolingController();
            coolingController.temperatureSensor = new TemperatureSensor();
            coolingController.radiator = new Radiator();
            airFlowController = new AirFlowController();
            airFlowController.flowMeter = new AirFlowMeter();
            fuelInjector = new FuelInjector();
            fuelInjector.fuelPump = new FuelPump();
            starter = new Starter();
            catalyticConverter = new CatalyticConverter();
        }

        public void InitializeTemperature(int temperature)
        {
            coolingController.temperatureSensor.SetTemperature(temperature);
        }

        public void InitializeAirFlow(int airFlow)
        {
            airFlowController.flowMeter.SetMeasurements(airFlow);
        }

        public string StartCar()
        {
            string startMessage = starter.Start();
            string catalyticConverterMessage = catalyticConverter.On();
            string coolingSystemMessage = coolingController.Run(coolingController.temperatureSensor.GetTemperature());
            string airFlowControllerMessage = airFlowController.TakeAir();
            string fuelInjectorMessage = fuelInjector.On();
            return $"{startMessage}\n{catalyticConverterMessage}\n{coolingSystemMessage}\n{airFlowControllerMessage}\n{fuelInjectorMessage}";
        }

        public string StopCar()
        {
            string catalyticConverterMessage = catalyticConverter.Off();
            string coolingSystemMessage = coolingController.Stop();
            string airFlowControllerMessage = airFlowController.Off();
            string fuelInjectorMessage = fuelInjector.Off();

            return $"{catalyticConverterMessage}\n{coolingSystemMessage}\n{airFlowControllerMessage}\n{fuelInjectorMessage}";
        }
    }
}
