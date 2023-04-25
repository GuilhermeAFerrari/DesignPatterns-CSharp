using AbstractFactory.App;
using AbstractFactory.Factories;

Application app = ConfigureApplication();

app.StartRoute();

Console.ReadLine();

static Application ConfigureApplication()
{
    Application app;

    ITransportFactory transportFactory;

    string company = "Uber";

    if (company == "Uber")
        transportFactory = new UberTransport();
    else if (company == "NineNine")
        transportFactory = new NineNineTransport();
    else if (company == "Lime")
        transportFactory = new LimeTransports();
    else
        throw new NotImplementedException("Companhia não implementada");

    app = new Application(transportFactory);

    return app;
}