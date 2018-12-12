using Avtec.DevMorningFix.ConsoleApp.Container;
using Avtec.DevMorningFix.Infrastructure;

namespace Avtec.DevMorningFix.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = new SimpleIocContainer();
            Bootstrapper.Configure(container);

            var startup = container.Resolve<IStartup>();
            startup.Start(args);
        }
    }
}