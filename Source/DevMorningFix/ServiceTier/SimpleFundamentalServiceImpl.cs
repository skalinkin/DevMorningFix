using System.Collections.Generic;
using Avtec.DevMorningFix.AvtecEngineeringFundamentals;
using Avtec.DevMorningFix.ServiceTier.DataManager;

namespace Avtec.DevMorningFix.ServiceTier
{
    public class SimpleFundamentalServiceImpl : ISimpleFundamentalService
    {
        private static IDataManager _dataManager;

        public void Initialize()
        {
            _dataManager = new XmlManager();
        }

        public IEnumerable<string> GetFundamentalNames()
        {
            return _dataManager.GetFundamentalNames();
        }

        public IEnumerable<string> GetFundamentalIDs()
        {
            return _dataManager.GetFundamentalIDs();
        }

        public IEnumerable<string> GetFundamentalDescriptions()
        {
            return _dataManager.GetFundamentalDescriptions();
        }

        public IDevFixFundamental GetDevFixFundamental(string name)
        {
            IDevFixFundamental f = new DevFixFundamental();
            return f;
        }

        public IDevFixFundamental GetDevFixFundamental(int id)
        {
            IDevFixFundamental f = new DevFixFundamental();
            return f;
        }

        public IEnumerable<IDevFixFundamental> GetFundamentalsList()
        {
            return _dataManager.GetFundamentalsList();
        }

        public bool DeleteFundamental(string name)
        {
            return true;
        }

        public bool CreateFundamental(int id, string name, string description)
        {
            return true;
        }

        public string GetFundamentalName(string id)
        {
            return _dataManager.GetFundamentalName(id);
        }

        public string GetFundamentalDescription(string id)
        {
            return _dataManager.GetFundamentalDescription(id);
        }
    }
}