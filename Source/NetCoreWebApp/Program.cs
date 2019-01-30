using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Avtec.DevMorningFix.Container;
using Avtec.NetCoreWebApp.DI;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;

namespace Avtec.NetCoreWebApp
{
    public class Pease : IServiceCollection
    {
        public IEnumerator<ServiceDescriptor> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(ServiceDescriptor item)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(ServiceDescriptor item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(ServiceDescriptor[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(ServiceDescriptor item)
        {
            throw new System.NotImplementedException();
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
        public int IndexOf(ServiceDescriptor item)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(int index, ServiceDescriptor item)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }

        public ServiceDescriptor this[int index]
        {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Bootstrapper.Instance.Configure();
            IServiceProvider poo = Bootstrapper.Instance.DependencyResolver;

            var webHostBuilder = CreateWebHostBuilder(args);
            
//            webHostBuilder.ConfigureServices(_=> _.Add));
            //webHostBuilder.ConfigureServices(p=>p)
            //webHostBuilder.ConfigureServices(_ => _.Add(poo));

            var webHost = webHostBuilder.Build();
            var webHost1 = new WebHostBuilder()
                .UseKestrel()
                .ConfigureServices(services => services.AddStructureMap())
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>();

            webHost.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var webHostBuilderJ = WebHost.CreateDefaultBuilder(args);
            var webHostBuilder = webHostBuilderJ.UseStartup<Startup>();
            return webHostBuilder;
        }
    }

}
