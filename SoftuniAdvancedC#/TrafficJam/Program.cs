using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int numOfCars = int.Parse(Console.ReadLine());
        Queue<string> queue = new Queue<string>();
        int count = 0;
        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            if (input != "green")
            {
                queue.Enqueue(input);
            }
            else
            {
                int carsToPass = Math.Min(numOfCars, queue.Count);
                for (int i = 0; i < carsToPass; i++)
                {
                    Console.WriteLine($"{queue.Dequeue()} passed!");
                    count++;
                }
            }
        }

        Console.WriteLine($"{count} cars passed the crossroads.");
    }
}
