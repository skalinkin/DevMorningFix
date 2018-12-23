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
            var appSettings = ConfigurationManager.AppSettings;
            for (var i = 0; i < appSettings.Count; i++)
            {
                string sInterfaceName = appSettings.GetKey(i);
                string sImplName = appSettings[i];
                //
                Type ifType = Type.GetType(sInterfaceName);
                Type implType = Type.GetType(sImplName);
                //
                container.Register(ifType, implType);
            }
        }
    }
}