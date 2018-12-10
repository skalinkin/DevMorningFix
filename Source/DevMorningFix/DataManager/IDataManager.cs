using Avtec.DevMorningFix.AvtecEngineeringFundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtec.DevMorningFix.DataManager
{
    public interface IDataManager
    {
        string GetFundamentalName(string ID);
        string GetFundamentalDescription(string ID);
        IEnumerable<IDevFixFundamental> GetFundamentalsList();
    }
}
