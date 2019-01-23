using System;
using System.Collections.Generic;
using System.Linq;
using Avtec.DevMorningFix.TempSpot.DataManager;

namespace Avtec.DevMorningFix.XmlStoreModule
{
    internal class FundamentalRepository : IFundamentalRepository
    {
        private readonly IDataManager _manager;

        public FundamentalRepository(IDataManager manager)
        {
            _manager = manager;
        }
        public IEnumerable<DevFixFundamental> GetAllFundamentals()
        {
            return _manager.GetFundamentalsList().Cast<DevFixFundamental>();
        }
    }
}