namespace GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            int lenght = ints.Count;
            List<int> sumedList = new List<int>();

            for (int i = 0; i < lenght / 2; i++)
            {

                sumedList.Add(ints[i] + ints[ints.Count - 1 - i]);
                

            }

            if (lenght % 2 != 0)
            {
                sumedList.Add(ints[ints.Count / 2 ]);
            }

            Console.WriteLine(string.Join(" ", sumedList));

        }
    }
}
