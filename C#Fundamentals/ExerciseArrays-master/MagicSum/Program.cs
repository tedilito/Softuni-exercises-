﻿namespace MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magigSum = int.Parse(Console.ReadLine());


            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == magigSum)
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]}");
                    }

                }
                
            }
        }
    }
}
