namespace MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> second = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            List<int> mergedList = new List<int>();
            int biggerLenght = first.Count;
            if (biggerLenght < second.Count)
            {
                biggerLenght = second.Count;
            }

            for (int i = 0; i < biggerLenght; i++)
            {
                if (first.Count > i)
                {
                    mergedList.Add(first[i]);
                }

                if (second.Count > i)
                {
                    mergedList.Add(second[i]);
                }
                
            }

            Console.WriteLine(string.Join(" ", mergedList));
        }
    }
}
