using ChainOfResponsibility.Middlewares;

namespace ChainOfResponsibility.Servers
{
    public class Server
    {
        private Dictionary<string, string> _users = new Dictionary<string, string>();

        private Middleware _middleware;

        public void SetMiddleware(Middleware middleware)
        {
            _middleware = middleware;
        }

        public bool Login(string email, string password)
        {
            if (_middleware.Check(email, password))
            {
                Console.WriteLine("Usuario autorizado com sucesso");
                Console.WriteLine("Seja bem-vindo!");
                return true;
            }
            return false;
        }

        public void RegisterUser(string email, string password)
        {
            _users[email] = password;
        }

        public bool HasEmail(string email)
        {
            return _users.ContainsKey(email);
        }

        public bool IsValidPassword(string email, string password)
        {
            var passwordFound = string.Empty;

            _users.TryGetValue(email, out passwordFound);

            return password == passwordFound;
        }

    }
}
