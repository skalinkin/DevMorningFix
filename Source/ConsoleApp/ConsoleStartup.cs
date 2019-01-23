using System;
using Avtec.DevMorningFix.BusinessCases;

namespace Avtec.DevMorningFix.ConsoleApp
{
    internal class ConsoleStartup : IStartup
    {
        private readonly IShowFundamentals _showFundamentalsBusinessCase;

        public ConsoleStartup(IShowFundamentals showFundamentalsBusinessCase)
        {
            _showFundamentalsBusinessCase = showFundamentalsBusinessCase;
        }

        public void Start(params object[] parameters)
        {
            _showFundamentalsBusinessCase.Execute();
            Console.ReadLine();
        }
    }
}