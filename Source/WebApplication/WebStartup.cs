using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Avtec.DevMorningFix.BusinessCases;
using Avtec.DevMorningFix.FormatOutput;

namespace Avtec.DevMorningFix.WebApp
{
    public class WebStartup : IStartup
    {
        private readonly IShowFundamentals _showFundamentalsBusinessCase;
        //private readonly IOutput outputOut;

       
        public WebStartup(IShowFundamentals showFundamentalsBusinessCase)
        {
            _showFundamentalsBusinessCase = showFundamentalsBusinessCase;
        }

        public void Start(params object[] parameters)
        {
            _showFundamentalsBusinessCase.Execute();

        }
    }
}