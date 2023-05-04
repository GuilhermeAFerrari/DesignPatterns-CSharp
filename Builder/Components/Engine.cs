using System.Numerics;

namespace Builder.Components
{
    public class Engine
    {
        public int Power { get; private set; }

        public Engine(int power)
        {
            Power = power;
        }
    }
}
