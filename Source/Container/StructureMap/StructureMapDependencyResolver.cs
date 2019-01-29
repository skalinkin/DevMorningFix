using System;
using System.ComponentModel.Composition;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;

namespace Avtec.DevMorningFix.Container.StructureMap
{
    [Export(typeof(IServiceProvider))]
    [ExportMetadata("Name", "StructureMap")]
    class StructureMapDependencyResolver : IServiceProvider
    {
        private bool _configured;
        private global::StructureMap.IContainer _container;
        public object GetService(Type serviceType)
        {
            if (!_configured)
            {
                Configure();
            }

            return _container.GetInstance(serviceType);
        }

        private void Configure()
        {
            //IServiceCollection services
            _configured = true;
            var strategy = new ContainerBuildStrategy();
            var container = strategy.CreateContainer();
            //_container.Populate(services);
            _container = container;
        }
    }
}