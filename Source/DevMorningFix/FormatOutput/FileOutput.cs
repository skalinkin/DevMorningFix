using Avtec.DevMorningFix.AvtecEngineeringFundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtec.DevMorningFix.FormatOutput
{
    class FileOutput : FundamentalFormattedOutput
    {
        public override void OutputFormatted(IDevFixFundamental f)
        {
            Console.WriteLine($" I need work !! {f.ID}: {f.Name} {f.Description} ");
        }
    }
}
