using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Autofac;

namespace Avtec.DevMorningFix.Container.Autofac
{
    internal class ContainerBuildStrategy
    {
        public global::Autofac.IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();

            var allAssemblies = new List<Assembly>();
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            foreach (var dll in Directory.GetFiles(path, "*.dll"))
            {
                allAssemblies.Add(Assembly.LoadFile(dll));
            }

            foreach (var exe in Directory.GetFiles(path, "*.exe"))
            {
                allAssemblies.Add(Assembly.LoadFile(exe));
            }

            foreach (var assembly in allAssemblies)
            {
                builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces();
            }
            
            var container = builder.Build();
            
            return container;
        }
    }
}