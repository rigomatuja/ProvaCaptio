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
            return _pass.Length >= MINLENGTH;
        }
    }
}