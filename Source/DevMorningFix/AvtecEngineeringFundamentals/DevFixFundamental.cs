using Avtec.DevMorningFix.ServiceTier.DataManager;

namespace Avtec.DevMorningFix.AvtecEngineeringFundamentals
{
    public class DevFixFundamental : IDevFixFundamental
    {
        private readonly IDataManager _dataManager;

        public DevFixFundamental()
        {
        }

        public DevFixFundamental(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public string Description { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }

        public void Initialize(string id)
        {
            ID = id;
            Name = _dataManager.GetFundamentalName(id);
            Description = _dataManager.GetFundamentalDescription(id);
        }
    }
}