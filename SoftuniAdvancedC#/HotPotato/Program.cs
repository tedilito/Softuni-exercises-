using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split();
        Queue<string> queue = new Queue<string>();
        foreach (var item in names)
        {
            queue.Enqueue(item);
        }
        int times = int.Parse(Console.ReadLine());

        while (queue.Count > 1)
        {
            for (int i = 1; i < times; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
            Console.WriteLine($"Removed {queue.Dequeue()}");
        }
        Console.WriteLine($"Last is {queue.Dequeue()}");
    }
}
