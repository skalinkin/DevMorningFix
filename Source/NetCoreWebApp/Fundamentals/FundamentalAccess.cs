using Avtec.DevMorningFix.AvtecEngineeringFundamentals;
using Avtec.DevMorningFix.TempSpot.DataManager;
using System.Collections.Generic;

namespace Avtec.NetCoreWebApp.Fundamentals
{
    public class FundamentalAccess : IFundamentalAccess
    {
        private readonly IDevFixFundamental _fundamental;
        private readonly IDataManager _dataManager;

        public FundamentalAccess(IDevFixFundamental fundamental, IDataManager dataManager)
        {
            _fundamental = fundamental;
            _dataManager = dataManager;
        }

        public List<DevFixFundamental> GetFundamentals()
        {
            //Todo: JPEase array
            var funList = new List<DevFixFundamental>
            {
                GetFundamental("1"),
                GetFundamental("2"),
                GetFundamental("3"),
                GetFundamental("4"),
                GetFundamental("5"),
                GetFundamental("6"),
                GetFundamental("7"),
                GetFundamental("8"),
                GetFundamental("9"),
                GetFundamental("10"),
                GetFundamental("11")
            };
            return funList;
        }

        public DevFixFundamental GetFundamental(string id)
        {
            var funda = new DevFixFundamental();
            funda.ID = id;
            funda.Name = _dataManager.GetFundamentalName(id);
            funda.Description = _dataManager.GetFundamentalDescription(id);
            return funda;
        }
    }
}
