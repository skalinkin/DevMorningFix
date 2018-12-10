using Avtec.DevMorningFix.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtec.DevMorningFix.AvtecEngineeringFundamentals
{
    public class DevFixFundamental : IDevFixFundamental
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }
        public DevFixFundamental()
        {
            ID = "ID not set";
            Name = "name not set";
            Description = "description not set";
        }

        public DevFixFundamental(string id, IDataManager dataManager)
        {
            ID = id;
            Name = dataManager.GetFundamentalName(id);
            Description = dataManager.GetFundamentalDescription(id);
        }

        public override string ToString()
        {
            return ID + ". " + Name + ". " + Description;
        }
    }
}
