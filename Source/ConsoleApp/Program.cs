using Avtec.DevMorningFix.ConsoleApp.Container;
using Avtec.DevMorningFix.Infrastructure;

namespace Avtec.DevMorningFix.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = GetContainer();

            var startup = container.Resolve<IStartup>();
            startup.Start(args);
        }

        private static IContainer GetContainer()
        {
            var container = new SimpleIocContainer();
            Bootstrapper.Configure(container);
            return container;
        }
    }
}