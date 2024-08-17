namespace DataTypesAndVariables_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int SecondNum = int.Parse(Console.ReadLine());
            int ThirdNum = int.Parse(Console.ReadLine());
            int FourthNum = int.Parse(Console.ReadLine());


            int add = firstNum + SecondNum;
            int devide = add / ThirdNum;
            int multiply = devide * FourthNum;

            Console.WriteLine(multiply);



        }
    }
}
