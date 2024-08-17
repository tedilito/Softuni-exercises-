namespace RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> original = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> listWithoutNegatives = new List<int> ();
            for (int i = 0; i < original.Count; i++)
            {
                if (original[i] >= 0)
                {
                    listWithoutNegatives.Add(original[i]);
                }
            }


            for (int i = listWithoutNegatives.Count - 1; i >= 0; i--)
            {
                Console.Write(listWithoutNegatives[i] + " ");

                //2nd way
                //listWithoutNegatives.Reverse();

            }

            if (listWithoutNegatives.Count == 0)
            {
                Console.WriteLine("empty");
            }

        }
    }
}
