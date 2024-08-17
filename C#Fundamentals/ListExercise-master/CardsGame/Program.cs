using System;
using System.Reflection;

namespace CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pl1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> pl2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            int index = pl1.Count;
            while (pl1.Count > 0 && pl2.Count > 0)
            {
                int pl1Card = pl1[0];
                int pl2Card = pl2[0];
                if(pl1Card > pl2Card)
                {
                    pl1.Add(pl1Card);
                    pl1.Add(pl2Card);
                }
                else if (pl1Card < pl2Card)
                {
                    pl2.Add(pl2Card);
                    pl2.Add(pl1Card);
                }
             

                pl1.RemoveAt(0);
                pl2.RemoveAt(0);

            }
            int sum = 0;
            string winner = string.Empty;
            if (pl1.Count > 0)
            {

                sum = pl1.Sum();
                winner = "First";

            }
            else 
            {
                sum = pl2.Sum();
                winner = "Second";
            }
            Console.WriteLine($"{winner} player wins! Sum: {sum}");
        }
    }
}
