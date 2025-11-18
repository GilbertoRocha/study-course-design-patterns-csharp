namespace ocp;

public class Vehicle : IVehicle
{
	protected string color;
	protected int year;
	protected double engine;

	public Vehicle(string color, int year, double engine)
	{
		this.engine = engine;
		this.color = color;
		this.year = year;
	}

	public void StartVehicle()
	{
		Console.WriteLine("Ligando os motores");
	}
}
