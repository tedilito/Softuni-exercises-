using System;

namespace GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal balance = decimal.Parse(Console.ReadLine());
            string game = "";
            string gameName = "";
            decimal spent = 0;
            decimal price = 0;
            decimal remaing;
            while ((game = Console.ReadLine()) != "Game Time")
            {
                
                switch (game)
                {
                    case "OutFall 4":
                        gameName = "OutFall 4";
                        price = 39.99m;
                        if (balance >= price)
                        {
                            Console.WriteLine($"Bought {gameName}");
                            balance -= price;
                            spent += price;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        break;
                    case "CS: OG":
                        gameName = "CS: OG";
                        price = 15.99m;
                        if (balance >= price)
                        {
                            Console.WriteLine($"Bought {gameName}");
                            spent += price;
                            balance -= price;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        break;
                    case "Zplinter Zell":
                        gameName = "Zplinter Zell";
                        price = 19.99m;
                        if (balance >= price)
                        {
                            Console.WriteLine($"Bought {gameName}");
                            spent += price;
                            balance -= price;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        break;
                    case "Honored 2":
                        gameName = "Honored 2";
                        price = 59.99m;
                        if (balance >= price)
                        {
                            Console.WriteLine($"Bought {gameName}");
                            spent += price;
                            balance -= price;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        break;
                    case "RoverWatch":
                        gameName = "RoverWatch";
                        price = 29.99m;
                        if (balance >= price)
                        {
                            Console.WriteLine($"Bought {gameName}");
                            spent += price;
                            balance -= price;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        gameName = "RoverWatch Origins Edition";
                        price = 39.99m;
                       
                        if (balance >= price)
                        {
                            Console.WriteLine($"Bought {gameName}");
                            spent += price;
                            balance -= price;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        break;

                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
             
            }
            if (balance > 0)
            {
                
                Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${balance:f2}");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}