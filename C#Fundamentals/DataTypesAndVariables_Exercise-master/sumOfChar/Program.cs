namespace sumOfChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfChars = int.Parse(Console.ReadLine());
            int sum = 0; 
            for (int i = 0; i < numOfChars; i++)
            {
                char input = char.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
