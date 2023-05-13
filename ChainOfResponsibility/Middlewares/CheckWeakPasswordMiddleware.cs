namespace ChainOfResponsibility.Middlewares
{
    public class CheckWeakPasswordMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password.Equals("1234"))
                Console.WriteLine("Senha considerada fraca. Considere alterar para maior segurança");

            return CheckNext(email, password);
        }
    }
}
