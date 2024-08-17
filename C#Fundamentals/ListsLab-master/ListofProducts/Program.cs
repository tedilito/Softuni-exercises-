namespace ListofProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }

            list.Sort();

            int c = 1;
            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine($"{c++}.{list[i]}");
            }



        }
    }
}
