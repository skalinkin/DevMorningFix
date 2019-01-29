using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Reflection;
using Autofac;

namespace Avtec.DevMorningFix.Container.Autofac
{
    [Export(typeof(IServiceProvider))]
    [ExportMetadata("Name", "Autofac")]
    internal class AutofacDependencyResolver : IServiceProvider
    {
        private bool _configured;
        private global::Autofac.IContainer _container;

        public T Create<T>() where T : class
        {
            if (!_configured)
            {
                Configure();
            }

            return _container.Resolve<T>();
        }

        private void Configure()
        {
            _configured = true;
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

            _container = builder.Build();
        }

        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }
    }
}