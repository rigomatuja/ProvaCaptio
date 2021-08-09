using System.Linq;

namespace ProvaCaptio.UseCases
{
    public class ValidateLowercase : IValidationRule
    {
        private readonly string _pass;

        public ValidateLowercase(string pass)
        {
            _pass = pass;
        }

        public override bool Validate()
        {
            return _pass.Any(char.IsLower);
        }
    }
}