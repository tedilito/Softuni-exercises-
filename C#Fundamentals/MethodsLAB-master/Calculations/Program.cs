

namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (operation == "add")
            {
                Sum(num1, num2);
            }
            else if (operation == "multiply")
            {
                Multiply(num1, num2);
            }
            else if (operation == "subtract")
            {
                Substract(num1, num2);
            }
            else if (operation == "divide")
            {
                Divide(num1, num2);
            }
        }

        private static void Divide(int num1, int num2)
        {
            int divided = num1 / num2;
            Console.WriteLine(divided);
        }

        private static void Substract(int num1, int num2)
        {
            int substracted = num1 - num2;
            Console.WriteLine(substracted);
        }

        private static void Multiply(int num1, int num2)
        {
           int multiplied = num1 * num2;
            Console.WriteLine(multiplied);
        }

        private static void Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
    }
}
