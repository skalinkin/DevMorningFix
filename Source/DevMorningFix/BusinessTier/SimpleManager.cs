using System.Collections.Generic;
using Avtec.DevMorningFix.AvtecEngineeringFundamentals;
using Avtec.DevMorningFix.ServiceTier;

namespace Avtec.DevMorningFix.BusinessTier
{
    public abstract class SimpleManager
    {
        private readonly ServiceByNameFactory _factory = ServiceByNameFactory.GetInstance();
        public abstract IEnumerable<IDevFixFundamental> GetFundamentals();
        public abstract IEnumerable<string> GetNames();
        public abstract IEnumerable<string> GetIDs();
        public abstract IEnumerable<string> GetDescriptions();
        public abstract bool CreateFundamental(int id, string name, string description);
        public abstract bool DeleteFundamental(string name);

        public ISimpleService GetService(string serviceName)
        {
            return _factory.GetService(serviceName);
        }
    }
}