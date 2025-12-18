namespace AbstractFactory;

public class UberTransport : ITransportFactory
{
	public IAircrafts CreateTransportAircraft()
	{
		return new Aircraft();
	}

	public ILandVehicle CreateTransportVehicle()
	{
		return new Car();
	}
}
