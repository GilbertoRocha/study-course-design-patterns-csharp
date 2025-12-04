namespace FactoryMethod;

public class Bike : IVehicle
{
	public void GetCargo()
	{
		Console.WriteLine("Pegando a marmita");
	}

	public void StartRoute()
	{
		GetCargo();
		Console.WriteLine("Iniciando entrega");
	}
}
