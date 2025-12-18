namespace AbstractFactory;

public class NineNineTransport : ITransportFactory
{
	public IAircrafts CreateTransportAircraft()
	{
		return new Helicopter();
	}

	public ILandVehicle CreateTransportVehicle()
	{
		return new Motorcycle();
	}
}
