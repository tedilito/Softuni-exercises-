namespace BasicSyntax_ConditionalStatmentsAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfStudent = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {nameOfStudent}, Age: {age}, Grade: {grade:f2}");
        }
    }
}
