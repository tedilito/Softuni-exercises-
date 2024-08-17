namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            decimal totalBudget = 0;
            decimal price = 0;
            while ((input = Console.ReadLine()) != "Start")
            {
                decimal budget = decimal.Parse(input);



                if (budget == 0.1m)
                {
                    totalBudget += budget;
                }
                else if (budget == 0.2m)
                {
                    totalBudget += budget;
                }
                else if (budget == 0.5m)
                {
                    totalBudget += budget;
                }
                else if (budget == 1m)
                {
                    totalBudget += budget;
                }
                else if (budget == 2m)
                {
                    totalBudget += budget;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {budget}");
                }
            }


            while ((input = Console.ReadLine()) != "End") 
            {
                string food = input.ToLower();
                switch (food)
                {
                    case "nuts":
                        price = 2.0m;
                        break;

                    case "water":
                        price = 0.7m;
                        break;
                    case "crisps":
                        price = 1.5m;
                        break;
                    case "soda":
                        price = 0.8m;
                        break;
                    case "coke":
                        price = 1.0m;
                        break;


                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                if (totalBudget >= price && price != 0)
                {
                    Console.WriteLine($"Purchased {food}");
                    totalBudget -= price;
                }
                else if (totalBudget < price && price != 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                }

            }

            if (input == "End")
            {
                Console.WriteLine($"Change: {totalBudget:f2}");
            }
        }
    }
}
