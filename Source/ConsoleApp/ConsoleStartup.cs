using System;
using Avtec.DevMorningFix.BusinessCases;
using Avtec.DevMorningFix.FormatOutput;
using Avtec.DevMorningFix.TempSpot.DataManager;

namespace Avtec.DevMorningFix.ConsoleApp
{
    internal class ConsoleStartup : IStartup
    {
        private readonly IShowFundamentals showFundamentalsBusinessCase;

        public ConsoleStartup(IShowFundamentals showFundamentalsBusinessCase)
        {
            this.showFundamentalsBusinessCase = showFundamentalsBusinessCase;
        }

        public void Start(params object[] parameters)
        {
            showFundamentalsBusinessCase.Show();
            Console.ReadLine();
        }
    }
}