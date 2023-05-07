using Bridge.Platforms;

namespace Bridge.Transmissions
{
    public class Live : ITransmission
    {
        protected IPlatform _platform;

        public Live(IPlatform platform)
        {
            _platform = platform;
        }

        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmissao na {_platform}");
        }

        public void Result()
        {
            Console.WriteLine("**** ON AIR ****");
        }
    }
}
