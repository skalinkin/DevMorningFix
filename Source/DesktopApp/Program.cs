using System;
using Avtec.DevMorningFix.Container;

namespace Avtec.DevMorningFix.DesktopApp
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Bootstrapper.Instance.Configure();
            var instanceDependencyResolver = Bootstrapper.Instance.DependencyResolver;
            var compositionRoot = instanceDependencyResolver.GetCompositionRoot();
            compositionRoot.Start();
        }
    }
}