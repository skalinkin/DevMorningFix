using Avtec.DevMorningFix.FormatOutput;
using Avtec.DevMorningFix.TempSpot.DataManager;

namespace Avtec.DevMorningFix.BusinessCases
{
    class ShowFundamentals : IShowFundamentals
    {
        private readonly IDataManager _dataManager;
        private readonly IOutput _output;

        public ShowFundamentals(IDataManager dataManage, IOutput output)
        {
            _dataManager = dataManage;
            _output = output;
        }
        public void Show()
        {
            var fl = _dataManager.GetFundamentalsList();
            foreach (var f in fl)
            {
                _output.OutputFormatted(f);
            }
        }
    }
}
