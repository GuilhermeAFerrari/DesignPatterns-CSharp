using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    public interface ITransportFactory
    {
        ILandVehicle CreateTransportVehicle();
        IAircraft CreateTransportAircraft();
    }
}