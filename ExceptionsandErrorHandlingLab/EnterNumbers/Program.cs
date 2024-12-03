using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    public class Program
    {
        static void Main()
        {


            ReadNumbers();



        }

        public static void ReadNumbers()
        {
            List<int> numbers = new List<int>();
            int end = 100;
            int start = 1;
            while (numbers.Count < 10)
            {
                string num = Console.ReadLine();
                try
                {
                    if (int.TryParse(num, out int parsedNum))
                    {

                        if (parsedNum > start && parsedNum < end)
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
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }

            Console.WriteLine(string.Join(", ", numbers));

        }
    }


}
