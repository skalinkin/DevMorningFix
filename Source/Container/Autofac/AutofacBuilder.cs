using System;
using System.ComponentModel.Composition;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Avtec.DevMorningFix.Container.Autofac
{
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