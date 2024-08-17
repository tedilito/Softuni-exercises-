using System.Numerics;

namespace EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
           bool isEven = false;

            while (input % 2 != 0) 
            {
                Console.WriteLine("Please write an even number.");
                 input = int.Parse(Console.ReadLine());
            }

            if (input % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(input)}");
            }
        }
    }
}
