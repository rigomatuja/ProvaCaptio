using System;

namespace ProvaCaptio
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Password Validator");
            Console.WriteLine("At least one uppercase character is required.");
            Console.WriteLine("At least one lowercase character is required.");
            Console.WriteLine("At least one number is required.");
            Console.WriteLine("A minimum length of 8 characters is required.");
            Console.WriteLine("\nType a password:");
            var validator = new ValidatePassword(Console.ReadLine());
            while (!validator.Validate())
            {
                Console.WriteLine("Type a password:");
                validator = new ValidatePassword(Console.ReadLine());
            }
            
            Console.WriteLine($"Congratulations! Password '{validator.getPasswordValue()}' is correct.");
        }
    }
}