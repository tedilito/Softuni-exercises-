using System.Diagnostics.Metrics;
using System.Xml;

namespace KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int[] arr = new int[lenght];
            int counter = 0;
            int sum = 0;
            int start = 0;
            int currStart = 0;
            int bestCounter = 0;
            string[] bestDna = new string[lenght];
            string input = " ";
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                arr = input.Split('!').Select(int.Parse).ToArray();


                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] == 1 && arr[i + 1] == 1)
                    {
                        currStart = i - counter;
                        counter++;
                        

                    }
                }
                int currSum = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 1)
                    {
                        currSum++;
                    }
                }
                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    bestDna = ; 
                    sum = currSum;
                    continue;

                }

                if (currSum > sum)
                {
                    bestDna = ;
                    sum = currSum;
                    continue;
                }

            }
           

        }










    }
}
