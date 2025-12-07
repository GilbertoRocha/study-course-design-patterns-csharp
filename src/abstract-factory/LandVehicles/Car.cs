namespace AbstractFactory;

public class Car : ILandVehicle
{
	public void GetCargo()
	{
		Console.WriteLine("Pegamos os passageiros, estamos prontos!");
	}

	public void StartRoute()
	{
		Console.WriteLine("Iniciando o trajeto");
	}



}
