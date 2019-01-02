using System.Collections.Generic;
using Avtec.DevMorningFix.AvtecEngineeringFundamentals;

namespace Avtec.Fundamentals
{
    public interface IFundamentalAccess
    {
        DevFixFundamental GetFundamental(string id);
        List<DevFixFundamental> GetFundamentals();
    }
}