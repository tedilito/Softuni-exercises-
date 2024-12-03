using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int bulletPrice = int.Parse(Console.ReadLine());
        int gunBarrelSize = int.Parse(Console.ReadLine());
        Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
        Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
        int intelligenceValue = int.Parse(Console.ReadLine());

        int totalBulletsFired = 0;
        int currentBarrelSize = gunBarrelSize;

        while (bullets.Count > 0 && locks.Count > 0)
        {
            int currentBullet = bullets.Pop();
            int currentLock = locks.Peek();
            totalBulletsFired++;
            currentBarrelSize--;

            if (currentBullet <= currentLock)
            {
                Console.WriteLine("Bang!");
                locks.Dequeue();
            }
            else
            {
                Console.WriteLine("Ping!");
            }

            if (currentBarrelSize == 0 && bullets.Count > 0)
            {
                Console.WriteLine("Reloading!");
                currentBarrelSize = gunBarrelSize;
            }
        }

        if (locks.Count == 0)
        {
            int moneyEarned = intelligenceValue - (totalBulletsFired * bulletPrice);
            Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
        }
        else
        {
            Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
        }
    }
}
