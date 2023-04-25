namespace AbstractFactory.Aircrafts
{
    public class Airplane : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando o ventos, vento a 25km, check ok");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros a bordo, voô autorizado");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem...");
        }
    }
}
