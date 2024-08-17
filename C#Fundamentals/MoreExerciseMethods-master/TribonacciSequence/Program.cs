
namespace TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            TribonacciSequence(num);
        }

        private static void TribonacciSequence(int num)
        {

            


            if (num == 1)
            {
                Console.Write("1");
            }
            else if (num == 2)
            {
                Console.Write("1 1");
            }
            else if (num >= 3)
            {
                long a = 1, b = 1, c = 2;
                Console.Write($"{a} {b} {c} ");
                for (int i = 4; i <= num; i++)
                {
                    long temp = a + b + c;
                    a = b;
                    b = c;
                    c = temp;
                    Console.Write($"{c} ");
                }
            }
            Console.WriteLine();

        }
    }
}
