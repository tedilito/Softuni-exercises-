
using System;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int num = int.Parse(input);
                    ActionBasedOnType(num);
                    break;
                case "real":
                    double numAsDouble = double.Parse(input);
                    ActionBasedOnType(numAsDouble);
                    break;
                case "string":
                    ActionBasedOnType(input);
                    break;

               
            }
        }

        private static void ActionBasedOnType(int num)
        {
            Console.WriteLine(num * 2);
        }

        private static void ActionBasedOnType(double numAsDouble)
        {
            Console.WriteLine($"{(numAsDouble * 1.5):f2}");
        }

        private static void ActionBasedOnType(string input)
        {
            Console.WriteLine("$" + input + "$");
        }
    }
}
