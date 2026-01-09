namespace Bridge;

public class AdvancedLive : Live
{
	public AdvancedLive(IPlatform platform) : base(platform)
	{
	}

	public void Subtitle()
	{
		Console.WriteLine("Legenda ativada!");
	}

	public void Comments()
	{
		Console.WriteLine("Comentários ativados!");
	}

}
