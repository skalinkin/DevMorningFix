using System;
using System.Configuration;

namespace Avtec.DevMorningFix.Infrastructure
{
    public static class Bootstrapper
    {
        public static void Configure(IContainer container)
        {
            var appSettings = ConfigurationManager.AppSettings;
            for (var i = 0; i < appSettings.Count; i++)
            {
                var sInterfaceName = appSettings.GetKey(i);
                var sImplName = appSettings[i];

                var ifType = Type.GetType(sInterfaceName, true, true);
                var implType = Type.GetType(sImplName, true, true);

                container.Register(ifType, implType);
            }
        }
    }
}