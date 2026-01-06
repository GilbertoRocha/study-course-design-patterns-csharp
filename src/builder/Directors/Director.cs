using Builder.Builders;
using Builder.Components;

namespace Builder;

public class Director
{

	IBuilder builder;

	public Director(IBuilder builder)
	{
		this.builder = builder;
	}

	public void ConstructSedanCar()
	{
		builder.SetVehicleType(VehiclesType.SEDAN);
		builder.SetSeats(5);
		builder.SetEngine(new Engine(2000));
		builder.SetTransmission(Transmission.AUTOMATIC);
	}

	public void ConstructTruck()
	{
		builder.SetVehicleType(VehiclesType.TRUCK);
		builder.SetSeats(2);
		builder.SetEngine(new Engine(6000));
		builder.SetTransmission(Transmission.MANUAL);
	}
}
