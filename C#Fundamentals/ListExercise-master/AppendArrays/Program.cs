using System.Globalization;

namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split("|");

            List<string> list = new List<string>();


            for (int i = arr.Length - 1; i >= 0 ; i--)
            {
                List<string> arrays = new List<string>();
                arrays = arr[i].Split(' ').ToList();
                list.AddRange(arrays);
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] == "")
                {
                    list.RemoveAt(i);
                }
            }

            Console.WriteLine(string.Join(" ", list));


        }
    }
}
