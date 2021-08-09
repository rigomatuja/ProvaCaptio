using System.Linq;

namespace ProvaCaptio.UseCases
{
    public class ValidateUppercase : IValidationRule
    {
        private readonly string _pass;

        public ValidateUppercase(string pass)
        {
            _pass = pass;
        }

        public override bool Validate()
        {
            return _pass.Any(char.IsUpper);
        }
    }
}