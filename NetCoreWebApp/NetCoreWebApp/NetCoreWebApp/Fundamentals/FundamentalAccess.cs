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
            var funList = new List<DevFixFundamental>();
            funList.Add(GetFundamental("1"));
            funList.Add(GetFundamental("2"));
            funList.Add(GetFundamental("3"));
            funList.Add(GetFundamental("4"));
            funList.Add(GetFundamental("5"));
            funList.Add(GetFundamental("6"));
            funList.Add(GetFundamental("7"));
            funList.Add(GetFundamental("8"));
            funList.Add(GetFundamental("9"));
            funList.Add(GetFundamental("10"));
            funList.Add(GetFundamental("11"));
            return null;
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
