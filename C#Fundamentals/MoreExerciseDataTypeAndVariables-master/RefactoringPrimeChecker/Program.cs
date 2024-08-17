namespace RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numEnd = int.Parse(Console.ReadLine());
            for (int i = 2; i <= numEnd; i++)
            {
                bool isPrime = true;
                for (int l = 2; l < i; l++)
                {
                    if (i % l == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, isPrime.ToString().ToLower());
            }

        }
    }
}
