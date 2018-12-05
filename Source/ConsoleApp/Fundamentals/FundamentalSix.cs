namespace Avtec.DevMorningFix.Fundamentals
{
    public class FundamentalSix
    {
        public FundamentalSix()
        {
            m_Fundamental = new Fundamental
            {
                Name = "6. High fan-in.",
                Description = "High fan-in refers to having a high number of classes that use a given class. High fan-in implies that a system has been designed to make good use of utility classes at the lower levels in the system."
            };
        }

        public override string ToString()
        {
            return m_Fundamental.ToString();
        }

        private Fundamental m_Fundamental;
    }
}
