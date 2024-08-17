

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());
            int multyplier = int.Parse(Console.ReadLine());
            if (multyplier <= 10)
            {
                for (int i = multyplier; i <= 10; i++)
                {
                    int product = i * userInput;
                    Console.WriteLine($"{userInput} X {i} = {product}");
                }
            }
            else
            {
                int product = userInput * multyplier;
                Console.WriteLine($"{userInput} X {multyplier} = {product}");
            }
            


        }
    }
}
