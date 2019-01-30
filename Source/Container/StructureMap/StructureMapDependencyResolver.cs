using System;
using System.ComponentModel.Composition;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;

namespace Avtec.DevMorningFix.Container.StructureMap
{

    class StructureMapThingy
    {
        private global::StructureMap.IContainer _container;

        public StructureMapThingy()
        {
        }

        [Export(typeof(IServiceProvider))]
        [ExportMetadata("Name", "StructureMap")]
        public IServiceProvider poo()
        {
            return new StructureMapServiceProvider(_container);
        }

        private void Configure()
        {
            var strategy = new ContainerBuildStrategy();
            _container = strategy.CreateContainer();
        }


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

                object poo = _container.GetInstance(serviceType);
                return _container.GetInstance(serviceType);
            }




            private void Configure()
            {
                //IServiceCollection services
                _configured = true;
                var strategy = new ContainerBuildStrategy();

                global::StructureMap.IContainer container = strategy.CreateContainer();
                var poo = new StructureMapServiceProvider(container);

                //_container.Populate(services);
                _container = container;
            }
        }
    }
}