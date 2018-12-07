namespace Avtec.DevMorningFix
{
    internal class NicksFundamental
    {
        public string Description { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name + Description;
        }
    }
}