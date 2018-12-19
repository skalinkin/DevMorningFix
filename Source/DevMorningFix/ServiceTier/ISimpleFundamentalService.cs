using System.Collections.Generic;
using Avtec.DevMorningFix.AvtecEngineeringFundamentals;

namespace Avtec.DevMorningFix.ServiceTier
{
    public interface ISimpleFundamentalService : ISimpleService
    {
        IEnumerable<string> GetFundamentalNames();
        IEnumerable<string> GetFundamentalIDs();
        IEnumerable<string> GetFundamentalDescriptions();
        IDevFixFundamental GetDevFixFundamental(string name);
        IDevFixFundamental GetDevFixFundamental(int id);
        IEnumerable<IDevFixFundamental> GetFundamentalsList();
        bool DeleteFundamental(string name);
        bool CreateFundamental(int id, string name, string description);
    }
}