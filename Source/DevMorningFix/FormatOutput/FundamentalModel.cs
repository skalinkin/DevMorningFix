using Avtec.DevMorningFix.AvtecEngineeringFundamentals;

namespace Avtec.DevMorningFix.FormatOutput
{
    internal class FundamentalModel : IFundamentalModel
    {
        public object[] GetData(IDevFixFundamental target)
        {
            return new[] {target.ID, target.Name, target.Description};
        }
    }
}