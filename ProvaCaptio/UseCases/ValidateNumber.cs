using System.Linq;

namespace ProvaCaptio.UseCases
{
    public class ValidateNumber : IValidationRule
    {
        private readonly string _pass;

        public ValidateNumber(string pass)
        {
            _pass = pass;
        }

        public override bool Validate()
        {
            return _pass.Any(char.IsDigit);
        }
    }
}