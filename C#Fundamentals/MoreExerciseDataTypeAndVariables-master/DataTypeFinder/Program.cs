using System;

namespace DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
         



            while (input != "END")
            {
                bool isInt = false;
                bool isFloating = false;
                bool isBool = false;
                bool isChar = false;

                try
                {
                    int integer = int.Parse(input);
                    isInt = true;
                }
                catch (SystemException)
                {

                    isInt = false;
                }

                try
                {
                    double floating = double.Parse(input);
                    isFloating = true;
                }
                catch (SystemException)
                {

                    isFloating = false;
                }

                try
                {
                    bool boolean = bool.Parse(input);
                    isBool = true;
                }
                catch (SystemException)
                {

                    isBool = false;
                }

                try
                {
                    char character = char.Parse(input);
                    isChar = true;
                }
                catch (SystemException)
                {

                    isChar = false;
                }


                if (isInt)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (isFloating)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (isChar)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (isBool)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();


            }






        }
    }
}
