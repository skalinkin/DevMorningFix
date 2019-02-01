using Microsoft.Extensions.DependencyInjection;
using StructureMap;

namespace Avtec.DevMorningFix.Container.StructureMap
{
    internal class ContainerBuildStrategy
    {
        public IServiceCollection SvcCollection { get; set; }

        public global::StructureMap.IContainer CreateContainer()
        {
            var container = new global::StructureMap.Container(
                _ => _.Scan
                (
                    x =>
                    {
                        x.TheCallingAssembly();
                        x.AssembliesFromApplicationBaseDirectory();
                        x.WithDefaultConventions();
                    })
            );

            if (SvcCollection != null)
            {
                container.Populate(SvcCollection);
            }

            return container;
        }
    }
}