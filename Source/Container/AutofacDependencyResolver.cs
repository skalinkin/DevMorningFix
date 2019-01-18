﻿using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Autofac;

namespace Avtec.DevMorningFix
{
    class AutofacDependencyResolver : IDependencyResolver
    {
        public IStartup GetCompositionRoot()
        {
            var builder = new ContainerBuilder();

            List<Assembly> allAssemblies = new List<Assembly>();
            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            foreach (string dll in Directory.GetFiles(path, "*.dll"))
                allAssemblies.Add(Assembly.LoadFile(dll));

            foreach (var assembly in allAssemblies)
            {
                builder.RegisterAssemblyTypes(assembly);
            }

            var container = builder.Build();
            var startup = container.Resolve<IStartup>();
            return startup;
        }
    }
}