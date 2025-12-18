namespace AbstractFactory;

public class Application
{

	private IAircrafts aircraft;

	private ILandVehicle vehicle;

	public Application(ITransportFactory factory)
	{
		aircraft = factory.CreateTransportAircraft();
		vehicle = factory.CreateTransportVehicle();
	}

	public void StartRoute()
	{
		vehicle.StartRoute();
		aircraft.StartRoute();
	}




}
