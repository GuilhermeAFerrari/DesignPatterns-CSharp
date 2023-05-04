using Builder.Components;
using Builder.Products;

namespace Builder.Builders
{
    public interface IBuiler
    {
        void Reset();
        Vehicle GetVehicle();
        void SetSeats(int seats);
        void SetEngine(Engine engine);
        void SetTransmission(Transmission transmission);
        void SetVehicleType(VehicleType vechicleType);
        void SetAirbags(bool airbags);
    }
}
