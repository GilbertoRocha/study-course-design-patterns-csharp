namespace Bridge;

public class Facebook : IPlatform
{
	public void AuthToken()
	{
		Console.WriteLine("Facebook: Autorizando Aplicação.");
	}

	public void ConfigureRMTP()
	{
		Console.WriteLine("Facebook: Configurando RMTP.");
	}
}
