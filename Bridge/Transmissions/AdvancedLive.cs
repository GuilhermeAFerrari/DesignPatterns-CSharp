using Bridge.Platforms;

namespace Bridge.Transmissions
{
    public class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform) : base(platform) { }

        public void Subtitle()
        {
            Console.WriteLine("Legendas ativadas na transmissao");
        }

        public void Comments()
        {
            Console.WriteLine("Comentarios liberador na live");
        }

        public void Record()
        {
            Console.WriteLine("Live sendo gravada");
        }
    }
}
