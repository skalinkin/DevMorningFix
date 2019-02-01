using System.Collections.Generic;
using Avtec.DevMorningFix;

namespace FundamentalsUnitTest
{
    class MockOutput : IOutput
    {
        public void OutputFormatted(IDevFixFundamental f)
        {
            throw new System.NotImplementedException();
        }

        public void OutputData(IEnumerable<IDevFixFundamental> fundamentals)
        {
            Fundamentals = fundamentals;
        }

        public IEnumerable<IDevFixFundamental> Fundamentals;
    }
}
