using System;

namespace ProvaCaptio.UseCases
{
    public class ValidateLength : IValidationRule
    {
        private const int MINLENGTH = 8;
        private readonly string _pass;

        public ValidateLength(string pass)
        {
            _pass = pass;
        }

        public override bool Validate()
        {
            Console.WriteLine($"Length >= {MINLENGTH}: {_pass.Length >= MINLENGTH}");
            return _pass.Length >= MINLENGTH;
        }
    }
}