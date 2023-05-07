namespace Bridge.Platforms
{
    public class DLive : IPlatform
    {
        public DLive()
        {
            ConfigureRMTP();
            Console.WriteLine("DLive: Transmissao iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("DLive: Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("DLive: Configurando servidor RMTP");
        }
    }
}
