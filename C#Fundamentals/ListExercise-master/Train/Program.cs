namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split();

                if (arguments[0] == "Add")
                {
                    list.Add(int.Parse(arguments[1]));
                }
                else
                {
                    int passengers = int.Parse(arguments[0]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] + passengers <= capacity)
                        {
                            list[i] += passengers;
                            break; 
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", list));

        }
    }
}
