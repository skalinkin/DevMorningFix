using System;
using System.ComponentModel.Composition;
using Autofac;
using Autofac.Extensions.DependencyInjection;


namespace Avtec.DevMorningFix.Container.Autofac
{
    [Export(typeof(IServiceProvider))]
    [ExportMetadata("Name", "Autofac")]
    internal class AutofacDependencyResolver : IServiceProvider
    {
        private bool _configured;
        private global::Autofac.IContainer _container;

        public object GetService(Type serviceType)
        {
            if (!_configured)
            {
                Configure();
            }
            var poo = new AutofacServiceProvider(_container);

            return _container.Resolve(serviceType);
        }

        private void Configure()
        {
            _configured = true;
            var strategy = new ContainerBuildStrategy();
            var container = strategy.CreateContainer();
            _container = container;
        }
    }
}