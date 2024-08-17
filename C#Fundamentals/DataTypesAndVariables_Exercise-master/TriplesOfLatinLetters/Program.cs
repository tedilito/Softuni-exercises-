namespace TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 97; i < 97 + n; i++)
            {
                for (int l = 97; l < 97 + n; l++)
                {
                    for (int j = 97; j < 97 + n; j++)
                    {
                        Console.WriteLine($"{(char)i}{(char)l}{(char)j}");
                    }
                }
            }
        }
    }
}
