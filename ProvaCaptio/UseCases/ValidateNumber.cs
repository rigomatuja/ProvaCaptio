using System;
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
            Console.WriteLine($"Contain Number: {_pass.Any(char.IsNumber)}");
            return _pass.Any(char.IsNumber);
        }
    }
}