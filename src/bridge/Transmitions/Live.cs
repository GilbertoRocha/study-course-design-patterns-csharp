namespace Bridge;

public class Live : ITransmition
{
	protected IPlatform platform;

	public Live(IPlatform platform)
	{
		this.platform = platform;
	}

	public void Broadcasting()
	{
		Console.WriteLine($"Iniciando a Transmissão na {platform}");
	}

	public void Result()
	{
		Console.WriteLine("**** ON AIR ****");
	}
}
