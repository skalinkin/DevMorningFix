using System;
using System.Collections.Generic;

namespace Avtec.DevMorningFix.FormatOutput
{
    internal class ConsoleOutput : IOutput
    {
        private readonly IFundamentalFormat _format;
        private readonly IFundamentalModel _model;

        public ConsoleOutput(IFundamentalFormat format, IFundamentalModel model)
        {
            _format = format;
            _model = model;
        }

        public virtual void OutputFormatted(IDevFixFundamental f)
        {
            var format = _format.GetFormat();
            var data = _model.GetData(f);
            var finalString = string.Format(format, data);
            Console.WriteLine(finalString);
        }

        public void OutputData(IEnumerable<IDevFixFundamental> fundamentals)
        {
            var format = _format.GetFormat();
            foreach (var fundamental in fundamentals)
            {
                var data = _model.GetData(fundamental);
                var finalString = string.Format(format, data);
                Console.WriteLine(finalString);
            }
        }
    }
}