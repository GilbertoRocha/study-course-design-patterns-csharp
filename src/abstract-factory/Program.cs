
using AbstractFactory;

static Application ConfigureApplication()
{
	string company = "Uber";


	return company switch
	{
		"Uber" => new Application(new UberTransport()),
		_ => new Application(new NineNineTransport()),
	};
}

Application app = ConfigureApplication();

app.StartRoute();
Console.ReadLine();

