using System;
using System.ComponentModel.Composition;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

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

    [Export(typeof(IDynamicServiceProvider))]
    [ExportMetadata("Name", "Autofac")]
    internal class AutofacBuilder : IDynamicServiceProvider
    {
        public IServiceProvider OurServiceProvider => GetServiceProvider();
        public IServiceCollection ServicesCollection { get; set; }

        private IServiceProvider GetServiceProvider()
        {
            var strategy = new ContainerBuildStrategy
            {
                SvcCollection = ServicesCollection
            };

            var container = strategy.CreateContainer();
            return new AutofacServiceProvider(container);
        }
    }
}