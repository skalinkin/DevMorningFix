using Avtec.DevMorningFix.Container;

namespace Avtec.DevMorningFix.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Bootstrapper.Instance.Configure();
            var instanceDependencyResolver = Bootstrapper.Instance.DependencyResolver;
            var compositionRoot = instanceDependencyResolver.GetCompositionRoot();
            compositionRoot.Start(args);
        }
    }
}