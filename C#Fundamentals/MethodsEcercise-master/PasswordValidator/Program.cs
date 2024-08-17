using System;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passInput = Console.ReadLine();
            IsValidPass(passInput);
        }

        private static void IsValidPass(string passInput)
        {
            bool itContainsNumChars = false;
            bool onlyLettersDigits = true; 
            bool itContains2Digits = false;
            int counterNum = 0;

            if (passInput.Length >= 6 && passInput.Length <= 10)
            {
                itContainsNumChars = true;
            }

            foreach (char c in passInput)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    onlyLettersDigits = false;
                    break; 
                }

                if (char.IsDigit(c))
                {
                    counterNum++;
                    if (counterNum >= 2)
                    {
                        itContains2Digits = true;
                    }
                }
                //if ((!(c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9'))) // another way for checking if there are only nums and letters
                //{

                //}


            }

            if (!itContainsNumChars)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!onlyLettersDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!itContains2Digits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (itContainsNumChars && onlyLettersDigits && itContains2Digits)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
