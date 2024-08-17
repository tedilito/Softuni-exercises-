namespace DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysInWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };


            int day = int.Parse(Console.ReadLine());



            if (day <= 0 || day > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysInWeek[day-1]);
            }
        }

    }
}
