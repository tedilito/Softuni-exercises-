namespace StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numCopy = num;
            int factorialSum = 0;
            
            while (numCopy > 0)
            {
                int digit = numCopy % 10;
                numCopy = numCopy / 10;
                int factorial = 1;
                for (int  i = 1; i <= digit; i++)
                {
                    factorial *= i;
                    
                }
               
                factorialSum += factorial;
              
            }

            string isStrong = factorialSum == num ? "yes" : "no";
            Console.WriteLine(isStrong);

        }
    }
}
