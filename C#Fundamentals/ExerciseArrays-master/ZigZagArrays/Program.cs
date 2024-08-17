namespace ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] SecondArr = new int[n];
            int f = 0, s = 1;
           
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
               

                if (f == 0)
                {
                   firstArr[i] = input[0];
                    f++;
                }
                else if (f == 1)
                {
                    firstArr[i] = input[1];
                        f = 0;
                }


                if (s == 1)
                {
                    SecondArr[i] = input[1];
                    s = 0;
                }
                else if (s == 0)
                {
                    SecondArr[i] = input[0];
                    s++;
                }





            }
            for (int i = 0; i < n; ++i)
            {
                Console.Write(firstArr[i] + " ");
                
            }
            Console.WriteLine();
            for (int i = 0; i < n; ++i)
            {
                Console.Write(SecondArr[i] + " ");

            }
        }
    }
}
