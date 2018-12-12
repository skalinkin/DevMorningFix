using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avtec.DevMorningFix.ServiceTier.DataManager;

namespace Avtec.DevMorningFix.AvtecEngineeringFundamentals
{
    public class DevFixFundamental : IDevFixFundamental
    {
        private IDataManager _dataManager;

        public string Description { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }

        public DevFixFundamental()
        {
        }

        public DevFixFundamental(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public void Initialize(string id)
        {
            ID = id;
            Name = _dataManager.GetFundamentalName(id);
            Description = _dataManager.GetFundamentalDescription(id);
        }
        public override string ToString()
        {
            return ID + ". " + Name + ". " + Description;
        }
    }
}
