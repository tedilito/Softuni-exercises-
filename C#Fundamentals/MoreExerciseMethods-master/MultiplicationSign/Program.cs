
namespace MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());


            Console.WriteLine(WhatSign(num1, num2, num3)); 

        }

        private static string WhatSign(int num1, int num2, int num3)
        {
            if (num1 < 0 || num2 < 0 || num3 < 0)
            {
                int negativeCount = 0;
                if (num1 < 0) negativeCount++;
                if (num2 < 0) negativeCount++;
                if (num3 < 0) negativeCount++;

                if (negativeCount % 2 == 0)
                {
                    return "positive";
                }
                else
                {
                    return "negative";
                }
            }
            else if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                return "zero";
            }
            else
            {
                return "positive";
            }


        }
    }
}
