using System;
using System.Collections.Generic;

namespace Avtec.DevMorningFix
{
    public interface IOutput
    {
        [Obsolete("Use OutputData instead.", false)]
        void OutputFormatted(IDevFixFundamental f);
        void OutputData(IEnumerable<IDevFixFundamental> fundamentals);
    }
}