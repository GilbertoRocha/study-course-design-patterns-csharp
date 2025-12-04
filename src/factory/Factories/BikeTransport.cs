namespace FactoryMethod;

public class BikeTransport : Transport
{
	protected override IVehicle CreateTransport()
	{
		return new Bike();
	}
}
