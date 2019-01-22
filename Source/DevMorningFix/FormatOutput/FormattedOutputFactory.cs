using System;
using System.Configuration;

namespace Avtec.DevMorningFix.FormatOutput
{
    public class FormattedOutputFactory : IFormattedOutputFactory
    {
        private readonly IOutput _output;

        public FormattedOutputFactory(IOutput output)
        {
            _output = output;
        }

        public IOutput GetFormattedOutput()
        {
            var configName = "FundamentalFormattedOutput";
            object obj = null;
            try
            {
                // can this be injected ??

                var outputName = GetOutputProviderName(configName);
                //string sTypeName = outputName;
                var objType = Type.GetType(outputName);
                obj = Activator.CreateInstance(objType);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Exception occured: {0}", e);
            }

            return (IOutput) obj;
        }

        private string GetOutputProviderName(string outputName)
        {
            var settings = ConfigurationManager.AppSettings;
            return settings.Get(outputName);
        }
    }
}