
namespace TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int interval = int.Parse(Console.ReadLine());
            IsTopNum(interval);
        }

        private static void IsTopNum(int interval)
        {
            
            for (int i = 1; i <= interval; i++)
            {
                int sumOfDigits = 0;
                bool isOddDigit = false;
                string num = i.ToString();
                
                for (int j = 0;  j < num.Length;  j++)
                {
                    sumOfDigits += num[j];
                    if (num[j] % 2 != 0)
                    {
                        isOddDigit = true; 
                    }
                }

                if (sumOfDigits % 8 == 0 && isOddDigit)
                {
                    Console.WriteLine(i);
                }


            }
        }
    }
}
