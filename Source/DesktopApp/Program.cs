using System;
using Avtec.DevMorningFix.Container;

namespace Avtec.DevMorningFix.DesktopApp
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            var instanceDependencyResolver = Bootstrapper.Instance.DependencyResolver;
            var compositionRoot = instanceDependencyResolver.GetCompositionRoot();
            compositionRoot.Start();
        }
    }
}