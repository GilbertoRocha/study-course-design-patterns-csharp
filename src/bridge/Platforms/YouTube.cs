namespace Bridge;

public class YouTube : IPlatform
{
	public void AuthToken()
	{
		Console.WriteLine("YouTube: Autorizando Aplicação.");
	}

	public void ConfigureRMTP()
	{
		Console.WriteLine("YouTube: Configurando RMTP.");
	}
}
