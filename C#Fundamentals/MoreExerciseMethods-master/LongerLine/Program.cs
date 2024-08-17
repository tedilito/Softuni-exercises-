
namespace LongerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            WhichIsLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);



        }

        private static void WhichIsLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double lineLenght1 = Math.Abs(x1) + Math.Abs(y1) + Math.Abs(x2) + Math.Abs(y2);
            double lineLenght2 = Math.Abs(x3) + Math.Abs(y3) + Math.Abs(x4) + Math.Abs(y4);


            if (lineLenght1 >= lineLenght2)
            {
                WhichIsCloser(x1, y1, x2, y2);
            }
            else
            {
                WhichIsCloser2(x3, y3, x4, y4);
            }


        }
        private static void WhichIsCloser(double x1, double y1, double x2, double y2)
        {


            double distance1 = Math.Abs(x1) + Math.Abs(y1);
            double distance2 = Math.Abs(x2) + Math.Abs(y2);


            if (distance1 <= distance2)
            {
                Console.Write($"({x1}, {y1})");
                Console.Write($"({x2}, {y2})");
            }
            else
            {

                Console.Write($"({x2}, {y2})");
                Console.Write($"({x1}, {y1})");
            }

        }

        private static void WhichIsCloser2(double x3, double y3, double x4, double y4)
        {


            double distance3 = Math.Abs(x3) + Math.Abs(y3);
            double distance4 = Math.Abs(x4) + Math.Abs(y4);


            if (distance3 <= distance4)
            {
                Console.Write($"({x3}, {y3})");
                Console.Write($"({x4}, {y4})");
            }
            else
            {

                Console.Write($"({x4}, {y4})");
                Console.Write($"({x3}, {y3})");
            }

        }

    }
}