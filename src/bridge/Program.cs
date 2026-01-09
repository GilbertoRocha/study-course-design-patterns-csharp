using Bridge;

static void StartLive(IPlatform platform)
{
	Console.WriteLine("Aguarde...");

	Live live = new(platform);

	live.Broadcasting();
	live.Result();
}

static void StartAdvancedLive(IPlatform platform)
{
	Console.WriteLine("Aguarde...");

	AdvancedLive live = new(platform);
	live.Broadcasting();
	live.Result();
	live.Comments();
	live.Subtitle();
	live.RecordLive();
}

StartLive(new YouTube());
StartLive(new Facebook());
StartLive(new TwitchTV());
StartAdvancedLive(new DLive());

Console.ReadLine();