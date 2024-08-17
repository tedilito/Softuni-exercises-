namespace StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int factorielSum = 0;
           
            int tmp = input;

            while (tmp > 0)
            {
                int digit = tmp % 10;
                tmp /= 10;
                int fact = 1;
                for (int i = 1; i <= digit; i++)
                {

                     fact *= i ;
                }
                
                factorielSum += fact;

                

            }

            string isStrong = factorielSum == input ? "yes" : "no";
            Console.WriteLine(isStrong);
        }
    }
}
