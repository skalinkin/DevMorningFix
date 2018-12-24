using System;
using System.Collections.Specialized;
using System.Configuration;
using DevMorningFix.services.Exceptions;

namespace Avtec.DevMorningFix.ServiceTier
{
    public class ServiceByNameFactory
    {
        private static readonly ServiceByNameFactory Factory = new ServiceByNameFactory();

        public static ServiceByNameFactory GetInstance()
        {
            return Factory;
        }

        public ISimpleService GetService(string serviceName)
        {
            try
            {
                string sImplName = GetImplName(serviceName);
                Type objType = Type.GetType(sImplName);
                ISimpleService iss = (ISimpleService)Activator.CreateInstance(objType ?? throw new InvalidOperationException());
                iss.Initialize();
                return iss;
            }
            catch (Exception e)
            {
                throw new ExceptionServiceNotFound($"No service named '{serviceName}' found.");
            }
        }
        private string GetImplName(String serviceName)
        {
            NameValueCollection settings = ConfigurationManager.AppSettings;
            return settings.Get(serviceName);
        }
    }
}