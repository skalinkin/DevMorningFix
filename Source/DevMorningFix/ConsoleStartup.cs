using System;
using Avtec.DevMorningFix.BusinessTier;
using Avtec.DevMorningFix.FormatOutput;

namespace Avtec.DevMorningFix
{
    internal class ConsoleStartup : IStartup
    {
        private readonly SimpleManager _businessManager;
        private readonly IOutput _output;

        public ConsoleStartup(SimpleManager businessManager, IOutput output)
        {
            _businessManager = businessManager;
            _output = output;
        }

        public void Start(params object[] parameters)
        {
            var fl = _businessManager.GetFundamentals();
            foreach (var f in fl)
            {
                _output.OutputFormatted(f);
            }

            Console.ReadLine();
        }
    }
}