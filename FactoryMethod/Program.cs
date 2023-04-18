using FactoryMethod.Factories;

static void main(string[] args)
{
    Transport? transport = null;

    if (args.Length > 0 && args[0] == "--uber")
    {
        transport = new CarTransport();
    }
    else if (args.Length > 0 && args[0] == "--log")
    {
        transport = new MotorcycleTransport();
    }
    else if (args.Length > 0 && args[0] == "--eats")
    {
        transport = new BikeTransport();
    }
    else
    {
        Console.WriteLine("Necessário informar algum parâmetro");
    }

    if (transport is not null)
    {
        transport.StartTransport();
    }
}

var parametros = new string[] { "--eats" };
main(parametros);
