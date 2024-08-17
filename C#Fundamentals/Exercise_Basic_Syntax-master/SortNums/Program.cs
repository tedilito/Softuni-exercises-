namespace SortNums
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());


            if (a > b )
            {
                
            }
            else
            {
                int tmp = b;
                b = a;
                a = tmp;
            }

            if (a > c)
            {

            }
            else
            {
                int tmp = c;
                c = a;
                a = tmp;
            }

            if (b > c)
            {
                
            }
            else
            {
                int tmp = c;
                c = b;
                b = tmp;
            }

            

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
