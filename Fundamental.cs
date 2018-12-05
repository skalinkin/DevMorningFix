namespace Avtec.DevMorningFix.Fundamentals
{
    public class Fundamental
    {
        public Fundamental()
        {
        }

        public string Name
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public override string ToString()
        {
            return Name + Description;
        }
    }
}
