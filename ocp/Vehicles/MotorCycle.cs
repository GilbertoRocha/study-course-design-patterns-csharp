namespace ocp;

public class MotorCycle : Vehicle
{
	public MotorCycle(string color, int year, double engine) : base(color, year, engine)
	{

		ConfigureMotorcycle();
	}

	public void ConfigureMotorcycle()
	{
		Console.WriteLine($"Criando uma Moto {color}, {year}, {engine} cilindradas.");
		StartVehicle();

	}
}
