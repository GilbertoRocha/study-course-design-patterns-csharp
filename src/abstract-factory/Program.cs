
using AbstractFactory;

static Application ConfigureApplication()
{
	string company = "Lime";


	return company switch
	{
		"Uber" => new Application(new UberTransport()),
		"Nine" => new Application(new NineNineTransport()),
		"Lime" => new Application(new LimeTransport()),
		_ => throw new Exception("Empresa de transporte não suportada.")
	};
}

Application app = ConfigureApplication();

app.StartRoute();
Console.ReadLine();

