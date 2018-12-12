using System;
using System.Collections.Generic;
using Avtec.DevMorningFix.AvtecEngineeringFundamentals;
using Avtec.DevMorningFix.BusinessTier;

namespace Avtec.DevMorningFix
{
    public interface IStartup
    {
        void Start(params object[] parameters);
    }

    class ConsoleStartup : IStartup
    {
        private readonly SimpleManager _businessManager;

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
            IEnumerable<IDevFixFundamental> fl = _businessManager.GetFundamentals();
            foreach (var f in fl)
            {
                Console.WriteLine(f.ToString() + "\n");
            }
            Console.ReadLine();
        }
    }
}