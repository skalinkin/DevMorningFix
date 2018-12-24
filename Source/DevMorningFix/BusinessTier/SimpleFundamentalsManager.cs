using System;
using System.Collections.Generic;
using Avtec.DevMorningFix.AvtecEngineeringFundamentals;
using Avtec.DevMorningFix.ServiceTier;

namespace Avtec.DevMorningFix.BusinessTier
{
    public class SimpleFundamentalsManager : SimpleManager
    {

        public override IEnumerable<IDevFixFundamental> GetFundamentals()
        {
            var simpleFundamentalSvc = (ISimpleFundamentalService) GetService(typeof(ISimpleFundamentalService));
            var objList = simpleFundamentalSvc.GetFundamentalsList();
            return objList;
        }

        public override IEnumerable<string> GetNames()
        {
            var simpleFundamentalSvc = (ISimpleFundamentalService) GetService(typeof(ISimpleFundamentalService));
            var objList = simpleFundamentalSvc.GetFundamentalNames();
            return objList;
        }

        public override IEnumerable<string> GetIDs()
        {
            var simpleFundamentalSvc = (ISimpleFundamentalService) GetService(typeof(ISimpleFundamentalService));
            var objList = simpleFundamentalSvc.GetFundamentalIDs();
            return objList;
        }

        public override IEnumerable<string> GetDescriptions()
        {
            var simpleFundamentalSvc = (ISimpleFundamentalService) GetService(typeof(ISimpleFundamentalService));
            var objList = simpleFundamentalSvc.GetFundamentalDescriptions();
            return objList;
        }

        public override bool CreateFundamental(int id, string name, string description)
        {
            var simpleFundamentalSvc = (ISimpleFundamentalService) GetService(typeof(ISimpleFundamentalService));
            return simpleFundamentalSvc.CreateFundamental(id, name, description);
        }

        public override bool DeleteFundamental(string name)
        {
            var simpleFundamentalSvc = (ISimpleFundamentalService) GetService(typeof(ISimpleFundamentalService));
            return simpleFundamentalSvc.DeleteFundamental(name);
        }

        public ISimpleService GetService(Type svcType)
        {
            string svcName = svcType.FullName;
            return Factory.GetService(svcName);
        }
    }
}