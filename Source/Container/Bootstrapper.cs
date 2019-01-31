using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Avtec.DevMorningFix.Container
{
    public sealed class Bootstrapper
    {
        private Bootstrapper()
        {
            Debug.Print("Creating instance of Bootstrapper.");
        }

        public static Bootstrapper Instance { get; } = new Bootstrapper();

        public IServiceProvider DependencyResolver { get; set; }

        [ImportMany(typeof(IServiceProvider))]
        public IEnumerable<Lazy<IServiceProvider, Dictionary<string, object>>> DependencyResolvers { get; set; }

        public void Configure()
        {
            Debug.Print("Configuring Bootstrapper.");
            var compositionContainer = GetContainer();
            compositionContainer.ComposeParts(Instance);
            DependencyResolver = SelectCurrentContainer();
        }

        private static CompositionContainer GetContainer()
        {
            var paths = GetPaths();

            foreach (var path in paths)
            {
                Debug.Print($"Path to scan for IServiceProvider {path}");
            }

            var catalog = new AggregateCatalog();
            foreach (var path in paths)
            {
                if(Directory.Exists(path))
                {
                    var part = new DirectoryCatalog(path, "*.dll");
                    Debug.Print($"Adding directory catalog for path {path}");
                    catalog.Catalogs.Add(part);
                }
            }

            var container = new CompositionContainer(catalog);
            return container;
        }

        private static string [] GetPaths()
        {
            var paths = new Collection<string>();

            paths.Add(AppDomain.CurrentDomain.BaseDirectory);
            paths.Add(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin"));
            return paths.ToArray();
        }

        private IServiceProvider SelectCurrentContainer()
        {
            var currentContainer = ConfigurationManager.AppSettings["Container"];

            if (string.IsNullOrEmpty(currentContainer))
            {
                return DependencyResolvers.First().Value;
            }

            var currentResolver = DependencyResolvers
                .Where(i => i.Metadata.ContainsKey("Name"))
                .Single(i => i.Metadata["Name"].ToString() == currentContainer);

            return currentResolver.Value;
        }
    }
}