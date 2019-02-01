using System;
using System.ComponentModel.Composition;
using StructureMap;

namespace Avtec.NetCoreWebApp.DI
{
    [Export(typeof(IServiceProvider))]
    [ExportMetadata("Name", "StructureMapForNetCore")]
    public class NetCoreWebAppStructureMapResolver:IServiceProvider
    {
        private Container _container;
        public object GetService(Type serviceType)
        {
            if (_container == null)
            {
                Configure();
            }

            return _container.GetInstance(serviceType);
        }

        private void Configure()
        {
            //Configure structure map here 
        }
    }
}