using System;

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
    }
}