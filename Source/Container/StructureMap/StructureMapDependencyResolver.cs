using System;
using System.ComponentModel.Composition;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;

namespace Avtec.DevMorningFix.Container.StructureMap
{
    [Export(typeof(IDynamicServiceProvider))]
    [ExportMetadata("Name", "StructureMap")]
    public class StructureMapBuilder : IDynamicServiceProvider
    {
        public IServiceProvider OurServiceProvider => GetServiceProvider();
        public IServiceCollection ServicesCollection { get; set; }

        public IServiceProvider GetServiceProvider()
        {
            var strategy = new ContainerBuildStrategy
            {
                SvcCollection = ServicesCollection
            };

            var container = strategy.CreateContainer();

            return new StructureMapServiceProvider(container);
        }
    }
}
