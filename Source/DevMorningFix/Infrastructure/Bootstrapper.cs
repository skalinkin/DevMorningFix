using Avtec.DevMorningFix.BusinessTier;
using Avtec.DevMorningFix.FormatOutput;
using Avtec.DevMorningFix.ServiceTier;
using Avtec.DevMorningFix.ServiceTier.DataManager;

namespace Avtec.DevMorningFix.Infrastructure
{
    public static class Bootstrapper
    {
        public static void Configure(IContainer container)
        {
            container.Register<IDataManager, SimpleFundamentalServiceImpl>();
            container.Register<SimpleManager, SimpleFundamentalsManager>();
            container.Register<IFormattedOutputFactory, FormattedOutputFactory>();
            container.Register<IFundamentalFormat, SimpleFormat>();
            container.Register<IFundamentalModel, FundamentalModel>();
            container.Register<IOutput, ConsoleOutput>();
        }
    }
}