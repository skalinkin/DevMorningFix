using Avtec.DevMorningFix.FormatOutput;

namespace Avtec.DevMorningFix.BusinessCases.Impl
{
    internal class ShowFundamentals : IShowFundamentals
    {
        private readonly IOutput _output;
        private readonly IFundamentalRepository _repository;

        public ShowFundamentals(IFundamentalRepository repository, IOutput output)
        {
            _repository = repository;
            _output = output;
        }

        public void Execute()
        {
            var fundamentals = _repository.GetAllFundamentals();
            foreach (var fundamental in fundamentals)
            {
                _output.OutputFormatted(fundamental);
            }
        }
    }
}