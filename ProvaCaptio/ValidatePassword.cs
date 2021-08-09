using System;
using System.Collections.Generic;
using ProvaCaptio.UseCases;

namespace ProvaCaptio
{
    public class ValidatePassword
    {
        public readonly List<int> faultLevel;
        public readonly ValidateLength validateLength;
        public readonly ValidateLowercase validateLower;
        public readonly ValidateNumber validateNumber;
        public readonly ValidateUppercase validateUpper;
        private ErrorTypeMessages _errorMessages;
        private readonly Password _pass;

        public ValidatePassword(string pass)
        {
            _pass = new Password(pass);
            validateUpper = new ValidateUppercase(_pass.Pass);
            validateLower = new ValidateLowercase(_pass.Pass);
            validateNumber = new ValidateNumber(_pass.Pass);
            validateLength = new ValidateLength(_pass.Pass);
            faultLevel = new List<int>();
        }

        public bool Validate()
        {
            if (!validateUpper.Validate())
                faultLevel.Add((int)ErrorTypes.Uppercase);
            else
                faultLevel.RemoveAll(rule => rule == (int)ErrorTypes.Uppercase);

            if (!validateLower.Validate())
                faultLevel.Add((int)ErrorTypes.Lowercase);
            else
                faultLevel.RemoveAll(rule => rule == (int)ErrorTypes.Lowercase);

            if (!validateNumber.Validate())
                faultLevel.Add((int)ErrorTypes.Number);
            else
                faultLevel.RemoveAll(rule => rule == (int)ErrorTypes.Number);

            if (!validateLength.Validate())
                faultLevel.Add((int)ErrorTypes.Length);
            else
                faultLevel.RemoveAll(rule => rule == (int)ErrorTypes.Length);

            foreach (var err in faultLevel) Console.WriteLine(err);


            if (faultLevel.Count > 1)
            {
                foreach (var error in faultLevel)
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