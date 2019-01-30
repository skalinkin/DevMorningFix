using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Avtec.DevMorningFix.Container.StructureMap;
using Microsoft.Extensions.DependencyInjection;

namespace Avtec.DevMorningFix.Container
{
    public sealed class Bootstrapper
    {
        private Bootstrapper()
        {
        }

        public static Bootstrapper Instance { get; } = new Bootstrapper();

        public IServiceProvider DependencyResolver { get; set; }
        
        [ImportMany(typeof(IDynamicServiceProvider))]
        public IEnumerable<Lazy<IDynamicServiceProvider, Dictionary<string, object>>> DependencyResolvers { get; set; }

        public void Configure()
        {
            var container = GetContainer();
            container.ComposeParts(Instance);

            var svcProvider = ResolveClassFromCompositionContainer();
            DependencyResolver = svcProvider.OurServiceProvider;

        }

        public void Configure(IServiceCollection servicesCollection)
        {
            var container = GetContainer();
            container.ComposeParts(Instance);

            var svcProvider = ResolveClassFromCompositionContainer();
            svcProvider.ServicesCollection = servicesCollection;

            DependencyResolver = svcProvider.OurServiceProvider;
        }

        private static void ComposeContainer()
        {
            var container = GetContainer();
            container.ComposeParts(Instance);
        }

        private static CompositionContainer GetContainer()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            var locationASP = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin");
            var path = Path.GetDirectoryName(location);
            var pathASP = locationASP;
            Debug.Assert(path != null, nameof(path) + " != null");
            var directoryCatalog = new DirectoryCatalog(path, "*.dll");
            var directoryCatalogASP = new DirectoryCatalog(pathASP, "*.dll");
            var catalog = new AggregateCatalog(directoryCatalog);
            catalog = new AggregateCatalog(directoryCatalog, directoryCatalogASP);
            var container = new CompositionContainer(catalog);
            return container;
        }

        private IDynamicServiceProvider ResolveClassFromCompositionContainer()
        {
            var currentContainer = ConfigurationManager.AppSettings["Container"];

            Lazy<IDynamicServiceProvider, Dictionary<string, object>> currentResolver = DependencyResolvers
                .Where(i => i.Metadata.ContainsKey("Name"))
                .Single(i => i.Metadata["Name"].ToString() == currentContainer);

            return currentResolver.Value;
        }
    }
}