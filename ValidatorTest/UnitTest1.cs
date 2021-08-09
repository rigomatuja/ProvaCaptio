using NUnit.Framework;
using ProvaCaptio;


namespace ValidatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void check_password_has_lowercase_letter()
        {
            string pass ="1234567e";
            ValidatePassword validator = new ValidatePassword(pass);
            bool hasLowerChar = validator.validateLower.Validate();
            
            Assert.True(hasLowerChar);
        }
        
        [Test]
        public void check_password_has_not_lowercase_letter()
        {
            string pass ="1234567E";
            ValidatePassword validator = new ValidatePassword(pass);
            bool hasLowerChar = validator.validateLower.Validate();
            
            Assert.False(hasLowerChar);
        }
        
        [Test]
        public void check_password_has_uppercase_letter()
        {
            string pass ="1234567E";
            ValidatePassword validator = new ValidatePassword(pass);
            bool hasUpperChar = validator.validateUpper.Validate();
            
            Assert.True(hasUpperChar);
        }
        
        [Test]
        public void check_password_has_no_uppercase_letter()
        {
            string pass ="1234567e";
            ValidatePassword validator = new ValidatePassword(pass);
            bool hasUpperChar = validator.validateUpper.Validate();
            
            Assert.False(hasUpperChar);
        }
        
        [Test]
        public void check_password_has_number()
        {
            string pass ="1234567e";
            ValidatePassword validator = new ValidatePassword(pass);
            bool hasNumber = validator.validateNumber.Validate();
            
            Assert.True(hasNumber);
        }
        
        [Test]
        public void check_password_has_no_number()
        {
            string pass ="eEeEeEeE";
            ValidatePassword validator = new ValidatePassword(pass);
            bool hasNumber = validator.validateNumber.Validate();
            
            Assert.False(hasNumber);
        }
        
        [Test]
        public void check_password_has_minimum_length()
        {
            string pass ="1234567e";
            ValidatePassword validator = new ValidatePassword(pass);
            bool hasMinLength = validator.validateLength.Validate();
            
            Assert.True(hasMinLength);
        }
        
        [Test]
        public void check_password_has_not_minimum_length()
        {
            string pass ="123456e";
            ValidatePassword validator = new ValidatePassword(pass);
            bool hasMinLength = validator.validateLength.Validate();
            
            Assert.False(hasMinLength);
        }
    }
}