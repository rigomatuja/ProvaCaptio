using System.Collections.Generic;
using ProvaCaptio.UseCases;

namespace ProvaCaptio
{
    public class ValidatePassword
    {
        private readonly List<int> _faultLevel;
        private Password _pass;
        private readonly ValidateLength _validateLength;
        private readonly ValidateLowercase _validateLower;
        private readonly ValidateNumber _validateNumber;
        private readonly ValidateUppercase _validateUpper;
        private ErrorTypeMessages _errorMessages;

        public ValidatePassword(string pass)
        {
            _pass = new Password(pass);
            _validateUpper = new ValidateUppercase(_pass.Pass);
            _validateLower = new ValidateLowercase(_pass.Pass);
            _validateNumber = new ValidateNumber(_pass.Pass);
            _validateLength = new ValidateLength(_pass.Pass);
            _faultLevel = new List<int>();
        }

        public bool Validate()
        {
            if (!_validateUpper.Validate())
                _faultLevel.Add((int)ErrorTypes.Uppercase);
            else
                _faultLevel.RemoveAll(rule => rule == (int)ErrorTypes.Uppercase);

            if (!_validateLower.Validate())
                _faultLevel.Add((int)ErrorTypes.Lowercase);
            else
                _faultLevel.RemoveAll(rule => rule == (int)ErrorTypes.Uppercase);

            if (!_validateNumber.Validate())
                _faultLevel.Add((int)ErrorTypes.Number);
            else
                _faultLevel.RemoveAll(rule => rule == (int)ErrorTypes.Number);

            if (!_validateLength.Validate())
                _faultLevel.Add((int)ErrorTypes.Length);
            else
                _faultLevel.RemoveAll(rule => rule == (int)ErrorTypes.Length);

            if (_faultLevel.Count > 1)
            {
                foreach (var error in _faultLevel)
                    _errorMessages = new ErrorTypeMessages(error);
                return false;
            }

            return true;
        }

        public string getPasswordValue()
        {
            return _pass.Pass;
        }
    }
}