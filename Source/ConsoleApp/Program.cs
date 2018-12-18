using Avtec.DevMorningFix.Infrastructure;
using Container;

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
            Register(container);
            return container;
        }

        private static void Register(IContainer container)
        {
            container.Register<IStartup, ConsoleStartup>();
        }
    }
}