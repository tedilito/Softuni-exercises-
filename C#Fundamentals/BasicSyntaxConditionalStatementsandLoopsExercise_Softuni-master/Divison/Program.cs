namespace Divison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());

          

            if (userInput % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (userInput % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (userInput % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (userInput % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (userInput % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
