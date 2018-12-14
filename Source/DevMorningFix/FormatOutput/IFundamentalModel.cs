using Avtec.DevMorningFix.AvtecEngineeringFundamentals;

namespace Avtec.DevMorningFix.FormatOutput
{
    internal interface IFundamentalModel
    {
        object[] GetData(IDevFixFundamental target);
    }
}