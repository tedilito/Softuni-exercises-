namespace AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;    
            int valueOfFirstChar = firstChar;
            int valueOfSecondChar = secondChar;
            for (int i = 0; i < input.Length; i++)
            {
                int valueOfInputChar = input[i];
                if (valueOfInputChar > valueOfFirstChar && valueOfInputChar < valueOfSecondChar)
                {
                    sum += valueOfInputChar;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
