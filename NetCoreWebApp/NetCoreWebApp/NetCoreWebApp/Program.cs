using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

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
