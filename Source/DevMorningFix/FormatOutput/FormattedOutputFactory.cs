using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avtec.DevMorningFix.ServiceTier;
using Avtec.DevMorningFix.ServiceTier.DataManager;
using DevMorningFix.services.Exceptions;

namespace Avtec.DevMorningFix.FormatOutput
{
    public class FormattedOutputFactory : IFormattedOutputFactory
    {
        FundamentalFormattedOutput IFormattedOutputFactory.GetFormattedOutput()
        {
            string configName = "FundamentalFormattedOutput";
            Object obj = null;
            try
            {
                // can this be injected ??

                string outputName = GetOutputProviderName(configName);
                //string sTypeName = outputName;
                Type objType = Type.GetType(outputName);
                obj = Activator.CreateInstance(objType);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Exception occured: {0}", e);
                throw new ExceptionServiceNotFound(string.Format($"No output format {configName} found."));
            }
            return (FundamentalFormattedOutput)obj;
        }
        private String GetOutputProviderName(String outputName)
        {
            NameValueCollection settings = ConfigurationManager.AppSettings;
            return settings.Get(outputName);
        }
    }
}
