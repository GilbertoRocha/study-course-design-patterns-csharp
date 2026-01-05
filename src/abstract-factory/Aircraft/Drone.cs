namespace AbstractFactory;

public class Drone : IAircrafts
{
	public void CheckWind()
	{
		Console.WriteLine("Verificando o vento.");
	}

	public void GetCargo()
	{
		Console.WriteLine("Pegando a carga.");
	}

	public void StartRoute()
	{
		CheckWind();
		GetCargo();
		Console.WriteLine("Iniciando a entrega.");
	}
}
