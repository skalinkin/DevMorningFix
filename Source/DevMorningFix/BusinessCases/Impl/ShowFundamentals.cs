using System;

namespace Avtec.DevMorningFix.BusinessCases.Impl
{
    internal class ShowFundamentals : IShowFundamentals
    {
        private readonly IFundamentalRepository _repository;
        private IOutput _output;

        public ShowFundamentals(IFundamentalRepository repository)
        {
            _repository = repository;
        }

        public void SetOutput(IOutput output)
        {
            _output = output;
        }

        public void Execute()
        {
            if (_output == null)
            {
                throw new InvalidOperationException("output wasn't set");
            }

            var fundamentals = _repository.GetAllFundamentals();
            _output.OutputData(fundamentals);
        }
    }
}