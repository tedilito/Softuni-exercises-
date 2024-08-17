namespace _3._WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine()) ;
            Dictionary<string, List<string>> wordsAndTheirSynonyms = new Dictionary<string, List<string>>();
            for (int i = 0; i < times; i++)
            {
                string wors = Console.ReadLine(); 
                string synonym = Console.ReadLine();
                if (wordsAndTheirSynonyms.ContainsKey(wors))
                {
                    wordsAndTheirSynonyms[wors].Add(synonym);
                }
                else
                {
                    wordsAndTheirSynonyms.Add(wors, new List<string>());
                    wordsAndTheirSynonyms[wors].Add(synonym);
                }
                

            }
            foreach (var w in wordsAndTheirSynonyms)
            {

                Console.WriteLine($"{w.Key} - {string.Join(", ", w.Value)}");
            }

        }
    }
}
