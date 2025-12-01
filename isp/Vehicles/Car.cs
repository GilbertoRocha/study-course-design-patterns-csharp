namespace isp.Vehicles;

public class Car : IVehicleCar
{
	private string color = "";
	private int year;
	private double engine;
	private int seats;
	private int doors;

	public Car(string color, int year, double engine, int seats, int doors)
	{
		ConfigureCar(color, year, engine, seats, doors);
	}

	public void ConfigureCar(string color, int year, double engine, int seats, int doors)
	{
		this.color = color;
		this.year = year;
		this.engine = engine;
		this.seats = seats;
		this.doors = doors;

		Console.WriteLine($"Criando carro ano {this.year}, motor {this.engine}, da cor {this.color} com {this.seats} assentos e {this.doors} portas");
		StartVehicle();
	}

	public void StartVehicle()
	{
		Console.WriteLine("Ligando os motores.");
	}
}
