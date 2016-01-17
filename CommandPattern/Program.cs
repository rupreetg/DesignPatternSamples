using CommandPattern.GenericLogger;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControlSetup remoteSetup = new RemoteControlSetup();
            RemoteControl remote = remoteSetup.InitializeRemote();

            ILogger logger = new CloudLogger();
            LogManager logManager = new LogManager(logger);
            logger.Log("Hi Logger!");
        }
    }
}
