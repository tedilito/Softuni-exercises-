namespace _02_Passed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double userGrade = double.Parse(Console.ReadLine());

            if (userGrade < 3.00)
            {
                Console.WriteLine("Failed!");
            }
            else { Console.WriteLine("Passed!"); }
        }
    }
}
