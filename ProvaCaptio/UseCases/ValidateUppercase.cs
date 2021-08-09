using System;
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
            Console.WriteLine($"Contain Uppercase: {_pass.Any(char.IsUpper)}");
            return _pass.Any(char.IsUpper);
        }
    }
}