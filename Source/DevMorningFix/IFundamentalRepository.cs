using System.Collections.Generic;

namespace Avtec.DevMorningFix
{
    internal interface IFundamentalRepository
    {
        IEnumerable<DevFixFundamental> GetAllFundamentals();
    }
}