namespace Bridge;

public class DLive : IPlatform
{
	public void AuthToken()
	{
		Console.WriteLine("DLive: Autorizando Aplicação.");
	}

	public void ConfigureRMTP()
	{
		Console.WriteLine("DLive: Configurando RMTP.");
	}
}
