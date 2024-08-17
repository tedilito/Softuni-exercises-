namespace _2._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();


            Dictionary<string, int> words = new Dictionary<string, int>();

            for (int i = 0; i < input.Count; i++)
            {
                string word = input[i].ToLower();

                if (words.ContainsKey(word))
                {
                    words[word]++; 
                }
                else
                {
                    words.Add(word, 1);
                }
            }

            foreach (var word in words)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write(word.Key + " ");
                }
            }


        }
    }
}
