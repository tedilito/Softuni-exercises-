using System.Numerics;

namespace BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            factorial factorial = new factorial();
            factorial.num = int.Parse(Console.ReadLine());
            factorial.GetFactorial();
        }


        public class factorial
        {
            public int num { get; set; }
            public BigInteger factorialTotal { get; set; }

            public void GetFactorial()
            {
                factorialTotal = 1;

                for (int i = 1; i <= num; i++)
                {
                    factorialTotal *= i;
                }
                Console.WriteLine(factorialTotal);
            }



        }

    }
}
