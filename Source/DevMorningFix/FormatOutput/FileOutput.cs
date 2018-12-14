using System;
using Avtec.DevMorningFix.AvtecEngineeringFundamentals;

namespace Avtec.DevMorningFix.FormatOutput
{
    internal class FileOutput : IOutput
    {
        public virtual void OutputFormatted(IDevFixFundamental f)
        {
            Console.WriteLine($" I need work !! {f.ID}: {f.Name} {f.Description} ");
        }
    }
}