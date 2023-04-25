using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.App
{
    public class Application
    {
        private IAircraft Aircraft;
        private ILandVehicle Vehicle;

        public Application(ITransportFactory factory)
        {
            Aircraft = factory.CreateTransportAircraft();
            Vehicle = factory.CreateTransportVehicle();
        }

        public void StartRoute()
        {
            Aircraft.StartRoute();
            Vehicle.StartRoute();
        }
    }
}
