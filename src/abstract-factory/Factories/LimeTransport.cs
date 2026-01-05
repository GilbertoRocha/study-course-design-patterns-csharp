namespace AbstractFactory;

public class LimeTransport : ITransportFactory
{
	public IAircrafts CreateTransportAircraft()
	{
		return new Drone();
	}

	public ILandVehicle CreateTransportVehicle()
	{
		return new Scooter();
	}
}
