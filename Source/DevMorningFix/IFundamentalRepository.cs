using System.Collections.Generic;

namespace Avtec.DevMorningFix
{
    public interface IFundamentalRepository
    {
        IEnumerable<DevFixFundamental> GetAllFundamentals();
    }
}