namespace Bridge;

public class TwitchTV : IPlatform
{
	public void AuthToken()
	{
		Console.WriteLine("TwitchTV: Autorizando Aplicação.");
	}

	public void ConfigureRMTP()
	{
		Console.WriteLine("TwitchTV: Configurando RMTP.");
	}
}
