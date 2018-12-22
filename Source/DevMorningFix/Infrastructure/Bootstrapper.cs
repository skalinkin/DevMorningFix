using System;
using System.Configuration;
using System.Reflection;
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
            /*
            container.Register<IDataManager, SimpleFundamentalServiceImpl>();
            container.Register<SimpleManager, SimpleFundamentalsManager>();
            container.Register<IFormattedOutputFactory, FormattedOutputFactory>();
            container.Register<IFundamentalFormat, SimpleFormat>();
            container.Register<IFundamentalModel, FundamentalModel>();
            container.Register<IOutput, ConsoleOutput>();

            leaving this in there for my brain
            */
            var appSettings = ConfigurationManager.AppSettings;
            for (var i = 0; i < appSettings.Count; i++)
            {
                string sInterfaceName = appSettings.GetKey(i);
                string sImplName = appSettings[i];
                //
                Type ifType = Type.GetType(sInterfaceName);
                Type implType = Type.GetType(sImplName);
                //
                // todo make this like the other registers where I can not specify LifeCycle
                // 
                container.Register(ifType, implType, LifeCycle.Singleton);
            }
        }
    }
}