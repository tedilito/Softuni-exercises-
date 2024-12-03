
using System.Numerics;

namespace SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split();
             int sum = 0;
            foreach (string element in elements)
            {
                sum += ValidElementResult(element);
                Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
            }
            Console.WriteLine($"The total sum of all integers is: {sum}");
        }

        private static int ValidElementResult(string element )
        {
            
           
            try
            {
                if (BigInteger.TryParse(element, out BigInteger result))
                {
                    if (result >= int.MinValue && result <= int.MaxValue)
                    {
                        return (int)result;
                    }
                    else
                    {
                        throw new OverflowException($"The element '{element}' is out of range!");
                    }
                }
                throw new FormatException($"The element '{element}' is in wrong format!");
               
            }
            catch (FormatException ex)
            {
                
                Console.WriteLine(ex.Message);
                return 0;

            }
            catch (OverflowException ex)
            {
               
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
