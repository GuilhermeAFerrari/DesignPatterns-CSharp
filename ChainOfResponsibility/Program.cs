using ChainOfResponsibility.Middlewares;
using ChainOfResponsibility.Servers;

var server = Init();

bool done = false;

do
{
    Console.WriteLine("Digite seu e-mail:");
    string email = Console.ReadLine();
    Console.WriteLine("Digite sua senha:");
    string password = Console.ReadLine();

    done = server.Login(email, password);

} while (!done);

Console.ReadLine();

Server Init()
{
    Server server = new();

    server.RegisterUser("master@email.com.br", "123456");
    server.RegisterUser("user@email.com.br", "1234");

    var checkUser = new CheckUserMiddleware(server);
    var checkPermission = new CheckPermissionMiddleware();
    var checkWeakPassword = new CheckWeakPasswordMiddleware();

    checkUser.LinkWith(checkPermission).LinkWith(checkWeakPassword);

    server.SetMiddleware(checkUser);

    return server;
}
