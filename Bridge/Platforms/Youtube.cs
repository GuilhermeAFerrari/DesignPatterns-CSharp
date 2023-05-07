namespace Bridge.Platforms
{
    public class Youtube : IPlatform
    {
        public Youtube()
        {
            ConfigureRMTP();
            Console.WriteLine("Youtube: Transmissao iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("Youtube: Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Youtube: Configurando servidor RMTP");
        }
    }
}
