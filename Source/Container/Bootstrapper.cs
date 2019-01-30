using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Configuration;
using System.IO;
using System.Linq;

namespace Avtec.DevMorningFix.Container
{
    public sealed class Bootstrapper
    {
        private Bootstrapper()
        {
        }

        public static Bootstrapper Instance { get; } = new Bootstrapper();

        public IServiceProvider DependencyResolver { get; set; }

        [ImportMany(typeof(IServiceProvider))]
        public IEnumerable<Lazy<IServiceProvider, Dictionary<string, object>>> DependencyResolvers { get; set; }

        public void Configure()
        {
            var compositionContainer = GetContainer();
            compositionContainer.ComposeParts(Instance);

            DependencyResolver = ResolveClassFromCompositionContainer();
        }

        private static CompositionContainer GetContainer()
        {
            var paths = GetPaths();

            var catalog = new AggregateCatalog();
            foreach (var path in paths)
            {
                if(Directory.Exists(path))
                {
                    var part = new DirectoryCatalog(path, "*.dll");
                    catalog.Catalogs.Add(part);
                }
            }

            var container = new CompositionContainer(catalog);
            return container;
        }

        private static IEnumerable<string> GetPaths()
        {
            var paths = new Collection<string>();

            paths.Add(AppDomain.CurrentDomain.BaseDirectory);
            paths.Add(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin"));
            return paths;
        }

        private IServiceProvider ResolveClassFromCompositionContainer()
        {
            var currentContainer = ConfigurationManager.AppSettings["Container"];

            var currentResolver = DependencyResolvers
                .Where(i => i.Metadata.ContainsKey("Name"))
                .Single(i => i.Metadata["Name"].ToString() == currentContainer);

            return currentResolver.Value;
        }
    }
}