using Avtec.DevMorningFix.AvtecEngineeringFundamentals;

namespace Avtec.DevMorningFix.FormatOutput
{
    public interface IFundamentalModel
    {
        object[] GetData(IDevFixFundamental target);
    }
}