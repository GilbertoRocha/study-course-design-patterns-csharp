namespace isp.Vehicles;

public class Motorcycle : IVehicleMotorcycle
{

	private string color = "";
	private int year;
	private double engine;

	public Motorcycle(string color, int year, double engine)
	{
		ConfigureMotorCycle(color, year, engine);
	}

	public void ConfigureMotorCycle(string color, int year, double engine)
	{
		this.color = color;
		this.year = year;
		this.engine = engine;

		Console.WriteLine($"Criando moto ano {this.year}, motor {this.engine} cilindradas, da cor {this.color}");

		StartVehicle();
	}

	public void StartVehicle()
	{
		Console.WriteLine("Ligando os motores.");
	}
}
