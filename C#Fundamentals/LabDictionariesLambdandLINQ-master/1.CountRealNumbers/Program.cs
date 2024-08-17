using System.Collections.Specialized;
using System.Linq;

namespace _1.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();
            SortedDictionary<double, int> orderedDictionary = new SortedDictionary<double, int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (!orderedDictionary.ContainsKey(input[i]))
                {
                    orderedDictionary.Add(input[i], 0);
                }
                orderedDictionary[input[i]]++;
            }
            foreach (var nums in orderedDictionary)
            {
                Console.WriteLine($"{nums.Key} -> {nums.Value}");
            }
        }
    }
}
