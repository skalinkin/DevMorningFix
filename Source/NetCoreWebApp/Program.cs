using Avtec.NetCoreWebApp.DI;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;

namespace Avtec.NetCoreWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webHostBuilder = CreateWebHostBuilder(args);
            var webHost = webHostBuilder.Build();
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
