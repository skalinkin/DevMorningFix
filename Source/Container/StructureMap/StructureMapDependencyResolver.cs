using System.ComponentModel.Composition;

namespace Avtec.DevMorningFix.Container.StructureMap
{
    [Export(typeof(IDependencyResolver))]
    [ExportMetadata("Name", "StructureMap")]
    class StructureMapDependencyResolver : IDependencyResolver
    {
        public IStartup GetCompositionRoot1()
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


            var startup = container.GetInstance<IStartup>();
            return startup;
        }
        public IStartup GetCompositionRoot()
        {
            throw new System.NotImplementedException();
        }
    }
}