using Avtec.DevMorningFix.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtec.DevMorningFix.AvtecEngineeringFundamentals
{
    public class FundamentalFive : IDevFixFundamental
    {
        private XmlManager xmlManager = new XmlManager();   // hopefully a container can cure this dependency
        public string Description { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }
        public FundamentalFive()
        {
            ID = "5";
            Name = "name not set";
            Description = "description not set";
        }

        public FundamentalFive(XmlManager xmlManager)
        {
            ID = "5";
            Name = xmlManager.GetFundamentalName(ID);   // ordering constraint - is that good
            Description = xmlManager.GetFundamentalDescription(ID);
        }

        public override string ToString()
        {
            return ID + ". " + Name + ". " + Description;
        }
    }
}
