namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string notReversed = Console.ReadLine();

            for (int i = notReversed.Length - 1; i >= 0; i--)
            {
                Console.Write(notReversed[i]);
            }
        }
    }
}
