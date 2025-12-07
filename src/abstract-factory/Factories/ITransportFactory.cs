namespace AbstractFactory;

public interface ITransportFactory
{
	IAircrafts CreateTransportAircraft();
	ILandVehicle CreateTransportVehicle();
}
