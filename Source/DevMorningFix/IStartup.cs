using System;
using System.Collections.Generic;
using Avtec.DevMorningFix.AvtecEngineeringFundamentals;
using Avtec.DevMorningFix.BusinessTier;
using Avtec.DevMorningFix.FormatOutput;

namespace Avtec.DevMorningFix
{
    public interface IStartup
    {
        void Start(params object[] parameters);
    }

    class ConsoleStartup : IStartup
    {
        private readonly SimpleManager _businessManager;
        // I tried injecting this but it died horribly
        private readonly IFormattedOutputFactory _formattedFactory = new FormattedOutputFactory();

        public ConsoleStartup(SimpleManager businessManager)
        {
            _businessManager = businessManager;
        }

        public void Start(params object[] parameters)
        {
            //
            // here we just fetch the whole fundamental strings - because that's all we are doing now
            // adding program args or some 'form' interface would do other stuff
            // other business manager items have unit tests
            //
            FundamentalFormattedOutput fundamentalFormattedOutput = _formattedFactory.GetFormattedOutput();
            IEnumerable<IDevFixFundamental> fl = _businessManager.GetFundamentals();
            foreach (var f in fl)
            {
                fundamentalFormattedOutput.OutputFormatted(f);
            }
            Console.ReadLine();
        }
    }
}