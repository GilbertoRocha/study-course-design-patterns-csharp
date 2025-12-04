namespace FactoryMethod;

public class MotorcycleTransport : Transport
{
	protected override IVehicle CreateTransport()
	{
		return new Motorcycle();
	}
}
