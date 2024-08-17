﻿using System.ComponentModel.Design;

namespace MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier <= 10)
            {
                for (int  i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");

                }
            }
            else
            {
                Console.WriteLine($"{n} X {multiplier} = {n * multiplier}");
            }
        
        
        }
    }
}
