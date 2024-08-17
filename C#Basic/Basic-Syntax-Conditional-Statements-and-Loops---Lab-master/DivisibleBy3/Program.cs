namespace DivisibleBy3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
           // int counter = 1;
            for (int i = 1; i <= n; i++) 
            {
               
                if (i % 2 != 0)
                {
                 Console.WriteLine(i);
                    //counter++;
                    sum += i;
                    //if (counter > n)
                    //{
                    //    break;
                    //}
                    
                }
                    
                
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
