namespace AbstractFactory;

public class Helicopter : IAircrafts
{
	public void CheckWind()
	{
		Console.WriteLine("Verificando vento, vento sudoeste, ventos ok!");
	}

	public void GetCargo()
	{
		Console.WriteLine("Passageiros ok, ligando as elices.");
	}

	public void StartRoute()
	{
		CheckWind();
		GetCargo();
		Console.WriteLine("Iniciando a decolagem!");
	}
}
