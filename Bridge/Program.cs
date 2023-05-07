using Bridge.Platforms;
using Bridge.Transmissions;

static void StartLive(IPlatform platform)
{
    Console.WriteLine("Aguarde ...");
    Live live = new (platform);
    live.Broadcasting();
    live.Result();
}

static void StartAdvancedLive(IPlatform platform)
{
    Console.WriteLine("Aguarde ...");
    AdvancedLive live = new(platform);
    live.Broadcasting();
    live.Subtitle();
    live.Comments();
    live.Record();
    live.Result();
}

StartAdvancedLive(new Youtube());
StartLive(new TwitchTV());
StartLive(new Facebook());
StartAdvancedLive(new DLive());

Console.ReadLine();