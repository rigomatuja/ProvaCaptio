using System;
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
            Console.WriteLine($"Contain Lowercase: {_pass.Any(char.IsLower)}");
            return _pass.Any(char.IsLower);
        }
    }
}