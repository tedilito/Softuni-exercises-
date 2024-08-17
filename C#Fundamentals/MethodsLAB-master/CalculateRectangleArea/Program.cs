namespace CalculateRectangleArea
{
    internal class Program
    {
        static int RectangleArea(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(RectangleArea(a, b));


        }


    }

}

