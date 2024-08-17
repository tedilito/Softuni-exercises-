namespace GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string input = "";
            decimal price = 0;
            decimal spent = 0; 
            

            while ((input = Console.ReadLine()) != "Game Time")
            {
                
                switch (input)
                {
                    case "OutFall 4":
                         
                        price = 39.99m;
                        if (price > money)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            money -= price;
                            spent += price;
                            Console.WriteLine($"Bought {input}");
                        }
                        break;
                    case "CS: OG":
                        price = 15.99m;
                        if (price > money)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            money -= price;
                            spent += price;
                            Console.WriteLine($"Bought {input}");
                        }
                        break;
                    case "Zplinter Zell":
                        price = 19.99m;
                        if (price > money)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            money -= price;
                            spent += price;
                            Console.WriteLine($"Bought {input}");
                        }
                        break;
                    case "Honored 2":
                        price  = 59.99m;
                        if (price > money)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            money -= price;
                            spent += price;
                            Console.WriteLine($"Bought {input}");
                        }
                        break;
                    case "RoverWatch":
                        price = 29.99m;
                        if (price > money)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            money -= price;
                            spent += price;
                            Console.WriteLine($"Bought {input}");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99m;
                        if (price > money)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            money -= price;
                            spent += price;
                            Console.WriteLine($"Bought {input}");
                        }
                        break;


                    default:
                        Console.WriteLine("Not Found");
                        continue;
                        
                }
                if (money == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }

            if (input == "Game Time")
            {
                Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${money:f2}");
            }

        }
    }
}
