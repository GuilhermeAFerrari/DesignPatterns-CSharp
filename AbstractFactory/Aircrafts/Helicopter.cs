using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    public class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando o ventos, vento sudeste, check ok");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros a bordo, voô autorizado, ligando as hélices");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem...");
        }
    }
}
