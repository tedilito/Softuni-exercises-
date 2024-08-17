
namespace MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());



            Console.WriteLine(NumByPowerOf(num, power));

        }

        static double NumByPowerOf(double num, int power)
        {
            //int result = num;


            //for (int i = 0; i < power - 1; i++)
            //{
            //    result *= num;
            //}\

            double result = Math.Pow(num, power);


            return result;
        }
    }
}
