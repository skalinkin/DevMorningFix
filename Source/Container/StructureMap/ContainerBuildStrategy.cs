using StructureMap;

namespace Avtec.DevMorningFix.Container.StructureMap
{
    internal class ContainerBuildStrategy
    {
        public global::StructureMap.IContainer CreateContainer()
        {
            var container = new global::StructureMap.Container(
                _ => _.Scan
                (x =>
                {
                    x.TheCallingAssembly();
                    x.AssembliesFromApplicationBaseDirectory();
                    x.WithDefaultConventions();
                    x.LookForRegistries();
                })
            );
            
            return container;
        }
    }
}