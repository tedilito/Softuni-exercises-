namespace DateModifier
{
    public class Program
    {
        public static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            DateModifier date = new DateModifier();
            int diffInDays = date.CalculateDateDiff(first, second);
            Console.WriteLine(diffInDays);
        }
    }
}