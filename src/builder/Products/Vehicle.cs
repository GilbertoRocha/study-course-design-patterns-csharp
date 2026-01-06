using Builder.Components;

namespace Builder.Products;

public class Vehicle
{
	private VehiclesType vehicleType;
	private int seats;
	private Engine engine;
	private Transmission transmission;

	public VehiclesType VehicleType
	{
		get => vehicleType;
		set => vehicleType = value;
	}

	public int Seats
	{
		get => seats;
		set => seats = value;
	}

	public Engine Engine
	{
		get => engine;
		set => engine = value;
	}

	public Transmission Transmission
	{
		get => transmission;
		set => transmission = value;
	}
}