using System;

namespace GenericSwapMethod
{
    public class Program
    {
        static void Main()
        {
      
            
            List<Box<double>> list = new List<Box<double>>();


            for (int i = 0; i < n; i++)
            {
                double element = double.Parse(Console.ReadLine());
                list.Add(new Box<double>(element));
            }


            double elementToCompare = double.Parse(Console.ReadLine());
            Box<double> boxToCompare = new Box<double>(elementToCompare);

            
            int count = CountGreaterElements(list, boxToCompare);

            
            Console.WriteLine(count);

        }
        public static int CountGreaterElements<T>(List<Box<T>> list, Box<T> element) where T : IComparable<T>
        {
            int count = 0;

            foreach (var box in list)
            {
                if (box.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }


    }
}