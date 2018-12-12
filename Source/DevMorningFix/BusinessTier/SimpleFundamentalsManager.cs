using System;
using System.Collections.Generic;
using Avtec.DevMorningFix.AvtecEngineeringFundamentals;
using Avtec.DevMorningFix.ServiceTier;
using DevMorningFix.services;

namespace Avtec.DevMorningFix.BusinessTier
{
    public class SimpleFundamentalsManager : SimpleManager
    {
        public override IEnumerable<IDevFixFundamental> GetFundamentals()
        {
            ISimpleFundamentalService simpleFundamentalSvc = (ISimpleFundamentalService)GetService("ISimpleFundamentalService");
            IEnumerable<IDevFixFundamental> objList = simpleFundamentalSvc.GetFundamentalsList();
            return objList;
        }

        public override IEnumerable<string> GetNames()
        {
            ISimpleFundamentalService simpleFundamentalSvc = (ISimpleFundamentalService)GetService("ISimpleFundamentalService");
            IEnumerable<string> objList = simpleFundamentalSvc.GetFundamentalNames();
            return objList;
        }
        public override IEnumerable<string> GetIDs()
        {
            ISimpleFundamentalService simpleFundamentalSvc = (ISimpleFundamentalService)GetService("ISimpleFundamentalService");
            IEnumerable<string> objList = simpleFundamentalSvc.GetFundamentalIDs();
            return objList;
        }

        public override IEnumerable<String> GetDescriptions()
        {
            ISimpleFundamentalService simpleFundamentalSvc = (ISimpleFundamentalService)GetService("ISimpleFundamentalService");
            IEnumerable<string> objList = simpleFundamentalSvc.GetFundamentalDescriptions();
            return objList;
        }

        public override bool CreateFundamental(int id, string name, string description)
        {
            ISimpleFundamentalService simpleFundamentalSvc = (ISimpleFundamentalService)GetService("ISimpleFundamentalService");
            return simpleFundamentalSvc.CreateFundamental(id, name, description);
        }

        public override bool DeleteFundamental(string name)
        {
            ISimpleFundamentalService simpleFundamentalSvc = (ISimpleFundamentalService)GetService("ISimpleFundamentalService");
            return simpleFundamentalSvc.DeleteFundamental(name);
        }

    }
}
