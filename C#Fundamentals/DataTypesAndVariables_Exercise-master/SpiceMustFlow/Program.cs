namespace SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int startingYield = int.Parse(Console.ReadLine());
            int countDays = 0;
            int spiceExtracted = 0;
            while (startingYield >= 100)
            {
                spiceExtracted += startingYield;
                startingYield -= 10;
                spiceExtracted -= 26;
                countDays++;
            }

            if (spiceExtracted >= 26)
            {
                spiceExtracted -= 26;
            }
            Console.WriteLine(countDays);
            Console.WriteLine(spiceExtracted);
        }
    }
}
