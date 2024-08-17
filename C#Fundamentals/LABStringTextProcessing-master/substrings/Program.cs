namespace substrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string words = Console.ReadLine();

            for (int i = 0; i < words.Length; i++)
            {
                if (words.Contains(wordToRemove))
                {int index = words.IndexOf(wordToRemove);
                     words = words.Remove(index,wordToRemove.Length);
                }
            }
            Console.WriteLine(words);



        }
    }
}
