using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger highestSnowballValue = 0;
            int bestSnow = 0, bestTime = 0, bestQuality = 0;  
            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (highestSnowballValue < value)
                {
                    highestSnowballValue = value;
                    bestSnow = snowballSnow;
                    bestQuality = snowballQuality;
                    bestTime = snowballTime;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {highestSnowballValue} ({bestQuality})");
        }
    }
}
