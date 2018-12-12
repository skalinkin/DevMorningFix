using System;
using System.Collections.Specialized;
using System.Configuration;
using Avtec.DevMorningFix.ServiceTier.DataManager;
using DevMorningFix.services;
using DevMorningFix.services.Exceptions;

namespace Avtec.DevMorningFix.ServiceTier
{
    public class ServiceByNameFactory
    {
        private static ServiceByNameFactory factory = new ServiceByNameFactory();

        public static ServiceByNameFactory GetInstance()
        {
            return factory;
        }

        public ISimpleService GetService(String serviceName)
        {
            // for debug
            // ReadAppSettings();
            // 
            IDataManager dataManager = null;
            Object obj = null;

            try
            {
                // can this be injected ??
                string sImplName = GetImplName(serviceName);
                string sTypeName = sImplName;
                if (serviceName.CompareTo("ISimpleFundamentalService") == 0)
                {
                    dataManager = new XmlManager();
                }
                else
                {
                    // TODO: add in a unit of work service for some ORM interface - e.g. entity framework, nhibernate
                    throw new ExceptionServiceNotFound(string.Format("Service named '{0}' is not supported.", serviceName));
                }
                Type objType = Type.GetType(sImplName);
                obj = Activator.CreateInstance(objType, dataManager);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Exception occured: {0}", e);
                throw new ExceptionServiceNotFound(string.Format("No service named '{0}' found.", serviceName));
            }

            if (serviceName.CompareTo("ISimpleFundamentalService") == 0)
            {
                return (ISimpleFundamentalService)obj;
            }
            else
            {
                // TODO: add in a unit of work service for some ORM interface - e.g. entity framework, nhibernate
                throw new ExceptionServiceNotFound(string.Format("Service named '{0}' is not supported.", serviceName));
            }
        }
        private String GetImplName(String serviceName)
        {
            NameValueCollection settings = ConfigurationManager.AppSettings;
            return settings.Get(serviceName);
        }
        private static void ReadAppSettings()
        {
            try
            {
                // Get the AppSettings section.
                NameValueCollection appSettings =
                   ConfigurationManager.AppSettings;

                // Get the AppSettings section elements.
                Console.WriteLine();
                Console.WriteLine("Using AppSettings property.");
                Console.WriteLine("Application settings:");

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("[ReadAppSettings: {0}]",
                    "AppSettings is empty Use GetSection command first.");
                }
                for (int i = 0; i < appSettings.Count; i++)
                {
                    Console.WriteLine("#{0} Key: {1} Value: {2}",
                      i, appSettings.GetKey(i), appSettings[i]);
                }
            }
            catch (ConfigurationErrorsException e)
            {
                Console.WriteLine("[ReadAppSettings: {0}]",
                    e.ToString());
            }
        }

    }
}
