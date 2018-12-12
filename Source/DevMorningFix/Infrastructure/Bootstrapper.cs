namespace Avtec.DevMorningFix.Infrastructure
{
    public static class Bootstrapper
    {
        public static void Configure(IContainer container)
        {
            container.Register<IStartup,ConsoleStartup>();
        }
    }
}