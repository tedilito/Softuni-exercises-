
namespace MiddleChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MiddleChars(input);
        }

        private static void MiddleChars(string input)
        {
            if (input.Length % 2 == 0)
            {
                int midIndex = (input.Length - 1) / 2;
                Console.Write(input[midIndex] );
                Console.WriteLine(input[midIndex + 1]);
            }
            else
            {
                double midIndex = Math.Floor(input.Length / 2.0);
                Console.WriteLine(input[(int)midIndex]);
            }
        }
    }
}
