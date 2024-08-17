namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double budget = 0;
            double price = 0;
            while ((input = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(input);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    budget += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                string food = input.ToLower();
                if (food == "nuts")
                {
                    price = 2.0;
                    if (budget >= price)
                    {
                        Console.WriteLine($"Purchased {food}");
                        budget -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (food == "water")
                {
                    price = 0.7;
                    if (budget >= price)
                    {
                        Console.WriteLine($"Purchased {food}");
                        budget -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (food == "crisps")
                {
                    price = 1.5;
                    if (budget >= price)
                    {
                        Console.WriteLine($"Purchased {food}");
                        budget -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (food == "soda")
                {
                    price = 0.8;
                    if (budget >= price)
                    {
                        Console.WriteLine($"Purchased {food}");
                        budget -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (food == "coke")
                {
                    price = 1.0;
                    if (budget >= price)
                    {
                        Console.WriteLine($"Purchased {food}");
                        budget -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {budget:f2}");

        }
    }
}
