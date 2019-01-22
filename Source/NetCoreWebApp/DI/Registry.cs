using Avtec.DevMorningFix;
using Avtec.DevMorningFix.TempSpot.DataManager;
using Avtec.NetCoreWebApp.Fundamentals;
using StructureMap;

namespace Avtec.NetCoreWebApp.DI
{
    public class FunRegistry : Registry
    {
        public FunRegistry()
        {
            For<IDevFixFundamental>().Use<DevFixFundamental>();
            For<IFundamentalAccess>().Use<FundamentalAccess>();
            For<IDataManager>().Use<XmlManager>();            
        }
    }
}