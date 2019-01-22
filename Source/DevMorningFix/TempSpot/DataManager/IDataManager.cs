using System.Collections.Generic;

namespace Avtec.DevMorningFix.TempSpot.DataManager
{
    public interface IDataManager
    {
        string GetFundamentalName(string ID);
        string GetFundamentalDescription(string ID);
        IEnumerable<IDevFixFundamental> GetFundamentalsList();
        IEnumerable<string> GetFundamentalNames();
        IEnumerable<string> GetFundamentalIDs();
        IEnumerable<string> GetFundamentalDescriptions();
        IDevFixFundamental GetDevFixFundamental(string name);
        IDevFixFundamental GetDevFixFundamental(int id);
        bool DeleteFundamental(string name);
        bool CreateFundamental(int id, string name, string description);
        bool ModifyFundamental(int id, string name, string description);
    }
}