namespace TheatrePromotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputDay = Console.ReadLine();
            int inputAge = int.Parse(Console.ReadLine());

            int price = 0;

            switch (inputDay)
            {
                case "Weekday":


                    if (inputAge >= 0 && inputAge <= 18)
                    {
                        price = 12;
                    }
                    else if (inputAge > 18 && inputAge <= 64)
                    {
                        price = 18;
                    }
                    else if (inputAge > 64 && inputAge <= 122)
                    {
                        price = 12;
                    }

                    break;

                case "Weekend":
                    if (inputAge >= 0 && inputAge <= 18)
                    {
                        price = 15;
                    }
                    else if (inputAge > 18 && inputAge <= 64)
                    {
                        price = 20;
                    }
                    else if (inputAge > 64 && inputAge <= 122)
                    {
                        price = 15;
                    }
                    break;

                case "Holiday":
                    if (inputAge >= 0 && inputAge <= 18)
                    {
                        price = 5;
                    }
                    else if (inputAge > 18 && inputAge <= 64)
                    {
                        price = 12;
                    }
                    else if (inputAge > 64 && inputAge <= 122)
                    {
                        price = 10;
                    }
                    break;


              
            }

            if (price == 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"{price}$");
            }
        }
    }
}
