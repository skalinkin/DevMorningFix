using System;
using Avtec.DevMorningFix.BusinessCases;

namespace Avtec.DevMorningFix.ConsoleApp
{
    internal class ConsoleStartup : IStartup
    {
        private readonly IOutput _output;
        private readonly IShowFundamentals _showFundamentalsBusinessCase;

        public ConsoleStartup(IShowFundamentals showFundamentalsBusinessCase, IOutput output)
        {
            _output = output;
            _showFundamentalsBusinessCase = showFundamentalsBusinessCase;
        }

        public void Start(params object[] parameters)
        {
            _showFundamentalsBusinessCase.SetOutput(_output);
            _showFundamentalsBusinessCase.Execute();
            Console.ReadLine();
        }
    }
}