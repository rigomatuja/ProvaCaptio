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
            var pass = "1234567e";
            var validator = new ValidatePassword(pass);
            var hasLowerChar = validator.validateLower.Validate();

            Assert.True(hasLowerChar);
        }

        [Test]
        public void check_password_has_not_lowercase_letter()
        {
            var pass = "1234567E";
            var validator = new ValidatePassword(pass);
            var hasLowerChar = validator.validateLower.Validate();

            Assert.False(hasLowerChar);
        }

        [Test]
        public void check_password_has_uppercase_letter()
        {
            var pass = "1234567E";
            var validator = new ValidatePassword(pass);
            var hasUpperChar = validator.validateUpper.Validate();

            Assert.True(hasUpperChar);
        }

        [Test]
        public void check_password_has_no_uppercase_letter()
        {
            var pass = "1234567e";
            var validator = new ValidatePassword(pass);
            var hasUpperChar = validator.validateUpper.Validate();

            Assert.False(hasUpperChar);
        }

        [Test]
        public void check_password_has_number()
        {
            var pass = "1234567e";
            var validator = new ValidatePassword(pass);
            var hasNumber = validator.validateNumber.Validate();

            Assert.True(hasNumber);
        }

        [Test]
        public void check_password_has_no_number()
        {
            var pass = "eEeEeEeE";
            var validator = new ValidatePassword(pass);
            var hasNumber = validator.validateNumber.Validate();

            Assert.False(hasNumber);
        }

        [Test]
        public void check_password_has_minimum_length()
        {
            var pass = "1234567e";
            var validator = new ValidatePassword(pass);
            var hasMinLength = validator.validateLength.Validate();

            Assert.True(hasMinLength);
        }

        [Test]
        public void check_password_has_not_minimum_length()
        {
            var pass = "123456e";
            var validator = new ValidatePassword(pass);
            var hasMinLength = validator.validateLength.Validate();

            Assert.False(hasMinLength);
        }
    }
}