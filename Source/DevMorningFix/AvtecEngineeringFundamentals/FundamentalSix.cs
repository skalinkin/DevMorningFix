namespace Avtec.DevMorningFix.AvtecEngineeringFundamentals
{
    public class FundamentalSix : Fundamental
    {
        private readonly NicksFundamental _mFundamental;

        public FundamentalSix()
        {
            _mFundamental = new NicksFundamental
            {
                Name = "6. High fan-in.",
                Description =
                    "High fan-in refers to having a high number of classes that use a given class. High fan-in implies that a system has been designed to make good use of utility classes at the lower levels in the system."
            };
        }

        public override string ToString()
        {
            return _mFundamental.ToString();
        }
    }
}