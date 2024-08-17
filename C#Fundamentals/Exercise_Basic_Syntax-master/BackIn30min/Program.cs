namespace BackIn30min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes > 59)
            {
                minutes -= 60;
                hours++;
            }

            if (hours > 23)
            {
                hours -= 24;
            }

        

            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:{minutes:d2}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }


         


        }
    }
}
