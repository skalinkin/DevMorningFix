using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avtec.DevMorningFix.AvtecEngineeringFundamentals;

namespace Avtec.DevMorningFix.FormatOutput
{
    class ConsoleOutput : FundamentalFormattedOutput
    {
        public override void OutputFormatted(IDevFixFundamental f)
        {
            Console.WriteLine($"{f.ID}:{f.Name}. {f.Description} ");
        }

    }
}
