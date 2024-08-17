namespace SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int tmp = 0;

            if (a > b)
            {
                
            }
            else
            {
                tmp = a;
                a = b;
                b = tmp;
            }

            if (a > c)
            {

            }
            else
            {
                tmp = a;
                a = c;
                c = tmp;

               
            }

            if (b > c)
            {

            }
            else
            {
                tmp = b;
                b = c;
                c = tmp;
                
            }

            



            Console.WriteLine( a);
            Console.WriteLine( b);
            Console.WriteLine( c);

        }



        }
    }

