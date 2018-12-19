using System;
using System.Configuration;
using DevMorningFix.services.Exceptions;

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
                throw new ExceptionServiceNotFound(string.Format($"No output format {configName} found."));
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