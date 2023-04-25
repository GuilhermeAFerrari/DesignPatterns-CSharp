using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    public class LimeTransports : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Drone();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new Scooter();
        }
    }
}
