using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtec.DevMorningFix.FormatOutput
{
    public interface IFormattedOutputFactory
    {
        FundamentalFormattedOutput GetFormattedOutput();
    }
}
