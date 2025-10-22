namespace srp;

public class Notify
{

	private readonly Client _client;
	
	public Notify(Client client)
	{
		_client = client;
	}

	
	public void NotifyClient()
	{
		Console.WriteLine("Notifying the client");
		_client.UpdateClient();

	}

}
