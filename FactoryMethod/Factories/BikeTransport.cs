using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    class BikeTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Bike();
        }
    }
}
