namespace Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input; 
            while ((input = Console.ReadLine()) != "end")
            {

                string reversedInput = string.Empty;
                for (int i = input.Length -1 ; i >= 0; i--)
                {
                    reversedInput += input[i];
                }
                Console.WriteLine($"{input} = {reversedInput}");

            }
        }
    }
}
