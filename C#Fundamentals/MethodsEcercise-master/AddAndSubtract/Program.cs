

namespace AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result = 0;
            int num3 = int.Parse(Console.ReadLine());

            SumOfFirstTwo(num1, num2, num3, result);
            

        }

        private static void SubstractResult(int result, int num3)
        {
            result = result - num3;
            Console.WriteLine(result);
        }

        private static void SumOfFirstTwo(int num1, int num2, int num3,  int result)
        {
           
            result = num1 + num2;
            SubstractResult(result, num3);

        }
    }
}
