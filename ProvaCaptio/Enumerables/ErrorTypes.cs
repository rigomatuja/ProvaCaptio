using System;

namespace ProvaCaptio
{
    public enum ErrorTypes
    {
        Uppercase = 1,
        Lowercase = 2,
        Number = 3,
        Length = 4
    }

    public class ErrorTypeMessages
    {
        public ErrorTypeMessages(int errorType)
        {
            switch (errorType)
            {
                case (int)ErrorTypes.Uppercase:
                    UppercaseFault();
                    break;
                case (int)ErrorTypes.Lowercase:
                    LowercaseFault();
                    break;
                case (int)ErrorTypes.Number:
                    NumberFault();
                    break;
                case (int)ErrorTypes.Length:
                    LengthFault();
                    break;
            }
        }

        public static void UppercaseFault()
        {
            Console.WriteLine("The password must contain at least one uppercase");
        }

        public static void LowercaseFault()
        {
            Console.WriteLine("The password must contain at least one lowercase");
        }

        public static void NumberFault()
        {
            Console.WriteLine("The password must contain at least one number");
        }

        public static void LengthFault()
        {
            Console.WriteLine("The password does not have the minimum characters required");
        }
    }
}