


using FactoryMethod;

if (args.Length == 0)
{
	Console.WriteLine("Selecione o tipo do servico");
}


Transport transport = args[0] switch
{
	"--log" => new MotorcycleTransport(),
	"--uber" => new CarTransport(),
	"--eat" => new BikeTransport(),
	_ => new CarTransport()
};

transport.StartTransport();

Console.ReadLine();