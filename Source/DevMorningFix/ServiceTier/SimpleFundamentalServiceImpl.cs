using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml.Linq;
using Avtec.DevMorningFix.AvtecEngineeringFundamentals;
using Avtec.DevMorningFix.ServiceTier.DataManager;
using DevMorningFix.services;

namespace Avtec.DevMorningFix.ServiceTier
{
    public class SimpleFundamentalServiceImpl : ISimpleFundamentalService
    {
        private static IDataManager _dataManager;

        public SimpleFundamentalServiceImpl(IDataManager dataManager)
        {
            _dataManager = dataManager;
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
            // get from data
            IDevFixFundamental f = new DevFixFundamental();
            return f;
        }

        public IDevFixFundamental GetDevFixFundamental(int id)
        {
            // get from data
            IDevFixFundamental f = new DevFixFundamental();
            return f;
        }

        public IEnumerable<IDevFixFundamental> GetFundamentalsList()
        {
            return _dataManager.GetFundamentalsList();
        }

        public string GetFundamentalName(string id)
        {
            return _dataManager.GetFundamentalName(id);
        }

        public string GetFundamentalDescription(string id)
        {
            return _dataManager.GetFundamentalDescription(id);
        }
        public bool DeleteFundamental(string name)
        {
            // get from data
            return true;
        }

        public bool CreateFundamental(int id, string name, string description)
        {
            // get from data
            return true;
        }
    }
}

