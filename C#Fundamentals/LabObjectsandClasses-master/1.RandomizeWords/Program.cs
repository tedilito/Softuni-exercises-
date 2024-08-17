namespace _1.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {

            RandomizeWords randomizeWords = new RandomizeWords();
        }
    }
    class RandomizeWords
    {
        public List<string> words { get; set; }
        public string input { get; set; }
        public RandomizeWords()
        {
            input = Console.ReadLine();
            words = input.Split().ToList();
            Random rand = new Random();
            for (int i = 0; i <= words.Count; i++)
            {
                int index = rand.Next(0, words.Count);
                Console.WriteLine(words[index]);
                words.Remove(words[index]);
                i = 0; 
            }

        }

    }

}
