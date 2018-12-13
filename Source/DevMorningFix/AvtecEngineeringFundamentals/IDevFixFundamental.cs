using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtec.DevMorningFix.AvtecEngineeringFundamentals
{
    public interface IDevFixFundamental
    {
        string ID { get; set; }
        string Description { get; set; }
        string Name { get; set; }
    }
}
