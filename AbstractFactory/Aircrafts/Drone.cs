using System;

namespace AbstractFactory.Aircrafts
{
    public class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando o ventos, ventos ok");
        }

        public void GetCargo()
        {
            Console.WriteLine("Carga coletada, ligando as hélices");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando percurso de entrega");
        }
    }
}
