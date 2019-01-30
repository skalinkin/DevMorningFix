using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Avtec.DevMorningFix.Container
{
    public sealed class Bootstrapper
    {
        private Bootstrapper()
        {
        }

        public static Bootstrapper Instance { get; } = new Bootstrapper();

        public IServiceProvider DependencyResolver { get; set; }

        public Action<IServiceProvider> AfterContainerReady = ((sp) => {});

        [ImportMany(typeof(IServiceProvider))]
        public IEnumerable<Lazy<IServiceProvider, Dictionary<string, object>>> DependencyResolvers { get; set; }

        public void Configure()
        {
            var container = GetContainer();

            container.ComposeParts(Instance);

            var currentContainer = ConfigurationManager.AppSettings["Container"];

            var currentResolver = DependencyResolvers
                .Where(i => i.Metadata.ContainsKey("Name"))
                .Single(i => i.Metadata["Name"].ToString() == currentContainer);

            AfterContainerReady(DependencyResolver);
            DependencyResolver = currentResolver.Value;
        }
        
        private static CompositionContainer GetContainer()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            var path = Path.GetDirectoryName(location);
            Debug.Assert(path != null, nameof(path) + " != null");
            var directoryCatalog = new DirectoryCatalog(path, "*.dll");
            var catalog = new AggregateCatalog(directoryCatalog);
            var container = new CompositionContainer(catalog);
            return container;
        }
    }
}