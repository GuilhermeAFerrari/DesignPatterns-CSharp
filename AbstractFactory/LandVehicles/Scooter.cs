namespace AbstractFactory.LandVehicles
{
    public class Scooter : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega");
        }
    }
}
