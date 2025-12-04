namespace FactoryMethod;

public class CarTransport : Transport
{
	protected override IVehicle CreateTransport()
	{
		return new Car();
	}
}
