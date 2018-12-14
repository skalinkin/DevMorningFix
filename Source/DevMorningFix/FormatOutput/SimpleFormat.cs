namespace Avtec.DevMorningFix.FormatOutput
{
    internal class SimpleFormat : IFundamentalFormat
    {
        public string GetFormat()
        {
            return "${0}:{1}. {2}";
        }
    }
}