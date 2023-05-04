using Builder.Components;
using Builder.Products;

namespace Builder.Builders
{
    public class VehicleBuilder : IBuiler
    {
        private Vehicle _vehicle = new Vehicle();

        public Vehicle GetVehicle()
        {
            Vehicle result = _vehicle;
            Reset();
            return result;
        }

        public void Reset()
        {
            _vehicle = new Vehicle();
        }

        public void SetEngine(Engine engine)
        {
            _vehicle.Engine = engine;
        }

        public void SetSeats(int seats)
        {
            _vehicle.Seats = seats;
        }

        public void SetTransmission(Transmission transmission)
        {
            _vehicle.Transmission = transmission;
        }

        public void SetVehicleType(VehicleType vechicleType)
        {
            _vehicle.VehicleType = vechicleType;
        }

        public void SetAirbags(bool airbags)
        {
            _vehicle.Airbags = airbags;
        }
    }
}
