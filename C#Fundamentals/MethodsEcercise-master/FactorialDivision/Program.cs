
namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int SecondNum = int.Parse(Console.ReadLine());


            FactorialDivision(firstNum, SecondNum);

        }

        private static void FactorialDivision(int firstNum, int secondNum)
        {
            double factorialFirst = 1;
            double factorialSecond = 1;


            for (int i = 1; i <= firstNum; i++)
            {
                factorialFirst *= i; 
            }

            for (int i = 1; i <= secondNum; i++)
            {
                factorialSecond *= i;
            }


            double devidedFactorials = factorialFirst / factorialSecond;
            Console.WriteLine($"{devidedFactorials:f2}");

        }
    }
}
