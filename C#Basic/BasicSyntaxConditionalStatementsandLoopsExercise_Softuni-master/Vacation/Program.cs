namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string typesOfGroup = Console.ReadLine(); //(Students, Business or Regular
            string dayOfWeek = Console.ReadLine();
            double price = 0; 
            switch (dayOfWeek)
            {

                case "Friday":
                    if (typesOfGroup == "Students")
                    {
                        price = 8.45;
                    }
                    else if (typesOfGroup == "Business")
                    {
                        price = 10.90;
                    }
                    else if (typesOfGroup == "Regular")
                    {
                        price = 15;
                    }
                    break;

                case "Saturday":
                    if (typesOfGroup == "Students")
                    {
                        price = 9.80;
                    }
                    else if (typesOfGroup == "Business")
                    {
                        price = 15.60;
                    }
                    else if (typesOfGroup == "Regular")
                    {
                        price = 20;
                    }
                    break;

                case "Sunday":
                    if (typesOfGroup == "Students")
                    {
                        price = 10.46;
                    }
                    else if (typesOfGroup == "Business")
                    {
                        price = 16.00;
                    }
                    else if (typesOfGroup == "Regular")
                    {
                        price = 22.50;
                    }
                    break; 






                default:
                    break;
            }
            double totalPrice = 0;
            if (peopleCount >= 30 && typesOfGroup == "Students")
            {
                totalPrice = price * peopleCount;
                totalPrice = totalPrice - (totalPrice * 0.15);
            }
            else if (peopleCount >= 100 && typesOfGroup == "Business")
            {

                totalPrice = price * (peopleCount - 10);


            }
            else if ((peopleCount >= 10 && peopleCount <= 20) && typesOfGroup == "Regular")
            {
                totalPrice = price * peopleCount;
                totalPrice = totalPrice - (totalPrice * 0.5);

            }
            else
            {
                totalPrice = price * peopleCount;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
