using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using Avtec.DevMorningFix;
using Avtec.DevMorningFix.Container;

namespace WebApplication
{
    public class Global : HttpApplication
    {
        private void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Bootstrapper.Instance.Configure();

            var resolver = Bootstrapper.Instance.DependencyResolver;
            var start = resolver.GetService<IStartup>();
            start.Start();
        }
    }
}