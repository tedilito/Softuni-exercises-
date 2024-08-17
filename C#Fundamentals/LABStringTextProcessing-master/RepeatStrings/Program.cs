namespace RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            string result = string.Empty;
            foreach (string s in strings)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    result += s;
                }
            }

            Console.WriteLine(result);
        }
    }
}
