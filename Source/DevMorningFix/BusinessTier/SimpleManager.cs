using System;
using System.Collections.Generic;
using Avtec.DevMorningFix.AvtecEngineeringFundamentals;
using Avtec.DevMorningFix.ServiceTier;
using DevMorningFix.services;

namespace Avtec.DevMorningFix.BusinessTier
{
    public abstract class SimpleManager
    {
        public abstract IEnumerable<IDevFixFundamental> GetFundamentals();
        public abstract IEnumerable<string> GetNames();
        public abstract IEnumerable<string> GetIDs();
        public abstract IEnumerable<String> GetDescriptions();
        public abstract bool CreateFundamental(int id, string name, string description);
        public abstract bool DeleteFundamental(string name);

        private readonly ServiceByNameFactory _factory = ServiceByNameFactory.GetInstance();

        public ISimpleService GetService(string serviceName)
        {
            return _factory.GetService(serviceName);
        }

    }
}
