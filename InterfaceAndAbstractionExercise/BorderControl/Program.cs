namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<INamerAndAger> list = new List<INamerAndAger>();
            List<IBuyer> buyers = new List<IBuyer>();
            for (int i = 0; i < n; i++)
            {
                string[] arguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
              
               
                if (arguments.Length == 4)
                {
                    Citizens citizens = new Citizens(arguments[0], int.Parse(arguments[1]) , arguments[2], arguments[3]);
                    list.Add(citizens);
                }
                else
                {
                    Rebel rebel = new Rebel(arguments[0], int.Parse(arguments[1]), arguments[2]);
                    list.Add(rebel);
                }
            }

            int totalPurchasedFood = 0; 
            string commands; 
            while ((commands = Console.ReadLine()) != "End")
            {
                if (list.Any(x => x.Name == commands))
                {
                    INamerAndAger namer = list.Where(x => x.Name == commands).FirstOrDefault();
                    IBuyer buyer = (IBuyer)namer;
                    buyer.BuyFood();

                    if (!buyers.Contains(buyer))
                    {
                        buyers.Add(buyer);

                    }
                    
                    
                }
            }

            foreach (var buyer in buyers)
            {
                totalPurchasedFood += buyer.Food;
            }
            Console.WriteLine(totalPurchasedFood);
        }
    }

}
