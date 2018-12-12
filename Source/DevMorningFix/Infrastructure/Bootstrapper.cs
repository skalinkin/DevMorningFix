using Avtec.DevMorningFix.BusinessTier;
using Avtec.DevMorningFix.ServiceTier;
using Avtec.DevMorningFix.ServiceTier.DataManager;

namespace Avtec.DevMorningFix.Infrastructure
{
    public static class Bootstrapper
    {
        public static void Configure(IContainer container)
        {
            // do we care about ordering ??
            // 
            container.Register<IDataManager, SimpleFundamentalServiceImpl>();
            container.Register<SimpleManager, SimpleFundamentalsManager>();
            container.Register<IStartup,ConsoleStartup>();
        }
    }
}