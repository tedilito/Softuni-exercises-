namespace TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string textToFilter = Console.ReadLine();
            
           
            for (int i = 0; i < bannedWords.Length; i++)
            {
                string textToReplace1 = new string('*', bannedWords[i].Length);
                if (textToFilter.Contains(bannedWords[i]))
                {
                   textToFilter = textToFilter.Replace(bannedWords[i], textToReplace1);
                }
               
            }
            Console.WriteLine(textToFilter);
        }
    }
}
