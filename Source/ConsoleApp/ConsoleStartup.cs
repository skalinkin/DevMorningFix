using System;
using Avtec.DevMorningFix.FormatOutput;
using Avtec.DevMorningFix.TempSpot.DataManager;

namespace Avtec.DevMorningFix.ConsoleApp
{
    internal class ConsoleStartup : IStartup
    {
        private readonly IDataManager _dataManager;
        private readonly IOutput _output;

        /*
            Note: 
            This in no way suggests an implementation, solution or any other final construct.
            This is simply code put in to allow further refactoring towards improvement.
            I.e., it allows stuff to work for now.
        */
        public ConsoleStartup(IDataManager dataManager, IOutput output)
        {
            _dataManager = dataManager;
            _output = output;
        }

        public void Start(params object[] parameters)
        {
            var fl = _dataManager.GetFundamentalsList();
            foreach (var f in fl)
            {
                _output.OutputFormatted(f);
            }

            Console.ReadLine();
        }
    }
}