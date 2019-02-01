using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Avtec.DevMorningFix.Container.Autofac
{
    internal class ContainerBuildStrategy
    {
        public IServiceCollection SvcCollection { get; set; }

        public global::Autofac.IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();

            var allAssemblies = new List<Assembly>();
            var paths = new Collection<string>();

            paths.Add(AppDomain.CurrentDomain.BaseDirectory);
            paths.Add(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin"));
            foreach (var path in paths)
            {
                if (Directory.Exists(path))
                {
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
                        Debug.Print($"Registering assembly {assembly}");
                        builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().InstancePerDependency();
                    }

                    if (SvcCollection != null)
                    {
                       builder.Populate(SvcCollection);
                    }

                }
            }

            var container = builder.Build();

                Debug.Print($"{container.ComponentRegistry.Registrations}");

            return container;
        }
    }
}