namespace BackIn30Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());


            minutes += 30;

            if (minutes >= 60)
            {
                hours++;
                minutes = minutes - 60;
            }

            if (hours >= 24)
            {
                hours = hours - 24;
            }

            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:{minutes:D2}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }

            for (int i = 1009 - 1; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

        }
    }
}
