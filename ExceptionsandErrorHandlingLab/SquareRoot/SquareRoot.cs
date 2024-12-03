using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    public class Program
    {
        static void Main()
        {
            try
            {
                ReadNumbers();
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }

        public static void ReadNumbers()
        {
            List<int> numbers = new List<int>();
            int end = 100;
            int start = 1;
            while (numbers.Count < 10)
            {
                string num = Console.ReadLine();
                if (int.TryParse(num, out int parsedNum))
                {
                    
                    if (parsedNum > start && start < end)
                    {
                        start = parsedNum;
                        numbers.Add(parsedNum);
                    }
                    else
                    {
                        throw new ArgumentException($"Your number is not in range {start} - 100!");
                    }
                }
                else
                {
                    throw new ArgumentException("Invalid Number!");
                }
            }

            Console.WriteLine(string.Join(", ", numbers));

        }
    }

    
}
