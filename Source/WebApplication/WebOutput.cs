using System;
using System.Collections.Generic;
using Avtec.DevMorningFix;
using Avtec.DevMorningFix.FormatOutput;

namespace WebApplication
{
    internal class WebOutput 
    {
        private readonly IFundamentalFormat _format;
        private readonly IFundamentalModel _model;

        public WebOutput(IFundamentalFormat format, IFundamentalModel model)
        {
            _format = format;
            _model = model;
        }

        public string OutputFormatted(IDevFixFundamental f)
        {
            var format = _format.GetFormat();
            var data = _model.GetData(f);
            var finalString = string.Format(format, data);
            return finalString;
        }

        public string OutputData(IEnumerable<IDevFixFundamental> fundamentals)
        {
            var format = _format.GetFormat();
            var finalString = String.Empty;
            foreach (var fundamental in fundamentals)
            {
                var data = _model.GetData(fundamental);
                finalString = string.Format(format, data);
                
            }
            return finalString;
        }
    }
}
