namespace AbstractFactory;

public class Scooter : ILandVehicle
{
	public void GetCargo()
	{
		Console.WriteLine("Pegamos o medicamento.");
	}

	public void StartRoute()
	{
		GetCargo();
		Console.WriteLine("Iniciamos a entrega.");
	}
}
