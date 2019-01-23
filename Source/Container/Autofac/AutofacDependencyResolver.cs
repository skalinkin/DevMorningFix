using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Reflection;
using Autofac;

namespace Avtec.DevMorningFix.Container.Autofac
{
    [Export(typeof(IDependencyResolver))]
    [ExportMetadata("Name", "Autofac")]
    class AutofacDependencyResolver : IDependencyResolver
    {
        public IStartup GetCompositionRoot()
        {
            var builder = new ContainerBuilder();

            List<Assembly> allAssemblies = new List<Assembly>();
            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            foreach (string dll in Directory.GetFiles(path, "*.dll"))
            {
                allAssemblies.Add(Assembly.LoadFile(dll));
            }

            foreach (string exe in Directory.GetFiles(path, "*.exe"))
            {
                allAssemblies.Add(Assembly.LoadFile(exe));
            }

            foreach (var assembly in allAssemblies)
            {
                builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces();
            }

            var container = builder.Build();
            var startup = container.Resolve<IStartup>();
            return startup;
        }
    }
}