namespace Bridge.Platforms
{
    public class TwitchTV : IPlatform
    {
        public TwitchTV()
        {
            ConfigureRMTP();
            Console.WriteLine("TwitchTV: Transmissao iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("TwitchTV: Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("TwitchTV: Configurando servidor RMTP");
        }
    }
}
