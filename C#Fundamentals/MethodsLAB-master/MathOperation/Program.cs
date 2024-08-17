
namespace MathOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


            Console.WriteLine(MathOperation(a, op, b));

        }

        private static double MathOperation(int a, char op, int b)
        {

            double result = 0;

            switch (op)
            {

                case '+':
                    result = a + b;
                    break;

                case '-':
                    result = a - b;
                    break;

                case '*':
                    result = a * b;
                    break;

                case '/':
                    result = a / b;
                    break;
            }

            return result;

        }
    }
}
