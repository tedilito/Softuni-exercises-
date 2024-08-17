


namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            CountOfVowels(input.ToLower());
        }

        private static void CountOfVowels(string input)
        {
            int countVowels = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'o' || input[i] == 'u' || input[i] == 'e' || input[i] == 'i'  )
                {
                    countVowels++;
                }
            }


            Console.WriteLine(countVowels);

        }
    }
}
