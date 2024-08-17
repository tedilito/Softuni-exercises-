
namespace PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num = 0;
            while ((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsPalindrome(input));
            } 
        }

        private static bool IsPalindrome(string input)
        {
            string reversed = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            if (input == reversed)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
