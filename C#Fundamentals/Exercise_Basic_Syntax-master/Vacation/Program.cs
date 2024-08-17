namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double Totalprice = 0;

            switch (day)
            {
                case "Friday":
                    if (typeGroup == "Students")
                    {
                        price = 8.45;
                    }
                    else if (typeGroup == "Business")
                    {
                        price = 10.90;
                    }
                    else if (typeGroup == "Regular")
                    {
                        price = 15;
                    }
                    break;

                case "Saturday":
                    if (typeGroup == "Students")
                    {
                        price = 9.80;
                    }
                    else if (typeGroup == "Business")
                    {
                        price = 15.60;
                    }
                    else if (typeGroup == "Regular")
                    {
                        price = 20;
                    }

                    break;

                case "Sunday":
                    if (typeGroup == "Students")
                    {
                        price = 10.46;
                    }
                    else if (typeGroup == "Business")
                    {
                        price = 16.00;
                    }
                    else if (typeGroup == "Regular")
                    {
                        price = 22.50;
                    }
                    break;

            }

            if (typeGroup == "Students" && countPeople >= 30)
            {
                Totalprice = price * countPeople;
                Totalprice -= Totalprice * 0.15;
            }
            else if (typeGroup == "Business" && countPeople >= 100)
            {
                Totalprice = price * (countPeople - 10);
            }
            else if (typeGroup == "Regular" && (countPeople >= 10 && countPeople <= 20))
            {
                Totalprice = price * countPeople;
                Totalprice -= Totalprice * 0.5;
            }
            else
            {
                Totalprice = price * countPeople;
            }

            Console.WriteLine($"Total price: {Totalprice:f2}");


        }
    }
}
