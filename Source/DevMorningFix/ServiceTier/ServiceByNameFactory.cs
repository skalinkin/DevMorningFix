using System;
using System.Configuration;
using Avtec.DevMorningFix.ServiceTier.DataManager;
using DevMorningFix.services.Exceptions;

namespace Avtec.DevMorningFix.ServiceTier
{
    public class ServiceByNameFactory
    {
        private static readonly ServiceByNameFactory factory = new ServiceByNameFactory();

        public static ServiceByNameFactory GetInstance()
        {
            return factory;
        }

        public ISimpleService GetService(string serviceName)
        {
            // for debug
            // ReadAppSettings();
            // 
            IDataManager dataManager = null;
            object obj = null;

            try
            {
                // can this be injected ??
                var sImplName = GetImplName(serviceName);
                var sTypeName = sImplName;
                if (serviceName.CompareTo("ISimpleFundamentalService") == 0)
                {
                    dataManager = new XmlManager();
                }
                else
                {
                    // TODO: add in a unit of work service for some ORM interface - e.g. entity framework, nhibernate
                    throw new ExceptionServiceNotFound(string.Format("Service named '{0}' is not supported.",
                        serviceName));
                }

                var objType = Type.GetType(sImplName);
                obj = Activator.CreateInstance(objType, dataManager);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Exception occured: {0}", e);
                throw new ExceptionServiceNotFound(string.Format("No service named '{0}' found.", serviceName));
            }

            if (serviceName.CompareTo("ISimpleFundamentalService") == 0)
            {
                return (ISimpleFundamentalService) obj;
            }

            // TODO: add in a unit of work service for some ORM interface - e.g. entity framework, nhibernate
            throw new ExceptionServiceNotFound(string.Format("Service named '{0}' is not supported.", serviceName));
        }

        private string GetImplName(string serviceName)
        {
            var settings = ConfigurationManager.AppSettings;
            return settings.Get(serviceName);
        }

        private static void ReadAppSettings()
        {
            try
            {
                // Get the AppSettings section.
                var appSettings =
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

                for (var i = 0; i < appSettings.Count; i++)
                {
                    Console.WriteLine("#{0} Key: {1} Value: {2}",
                        i, appSettings.GetKey(i), appSettings[i]);
                }
            }
            catch (ConfigurationErrorsException e)
            {
                Console.WriteLine("[ReadAppSettings: {0}]",
                    e);
            }
        }
    }
}