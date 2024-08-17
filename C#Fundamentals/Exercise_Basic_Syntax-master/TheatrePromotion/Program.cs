namespace TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            decimal price = 0;

            switch (day)
            {

                case "Weekday":

                    if (age >= 0 && age <= 18)
                    {
                        price = 12m;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 18m;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 12m;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }

                    break;

                case "Weekend":
                    if (age >= 0 && age <= 18)
                    {
                        price = 15m;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 20m;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 15m;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }

                    break;

                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 5m;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 12m;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 10m;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }


                    break;

            }
            if (price != 0)
            Console.WriteLine($"{price}$");
        }
    }
}
