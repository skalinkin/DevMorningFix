using Avtec.DevMorningFix;
using Avtec.DevMorningFix.BusinessCases;

namespace WebApplication
{
    public class WebStartup : IStartup
    {
        private readonly IShowFundamentals _showFundamentalsBusinessCase;

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