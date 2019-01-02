using Avtec.DevMorningFix.AvtecEngineeringFundamentals;
using StructureMap;

namespace Avtec.NetCoreWebApp.DI
{
    public class FunRegistry : Registry
    {
        public FunRegistry()
        {
            For<IDevFixFundamental>().Use<DevFixFundamental>();
        }
    }
}