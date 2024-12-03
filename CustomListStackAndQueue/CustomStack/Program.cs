

namespace CustomStack
{
    class Program
    {
        public static void Main(string[] args)
        {
            CustomStack<int> stack = new CustomStack<int>();

            string command = Console.ReadLine();

            while (command != "END")
            {

                if (command.StartsWith("Push"))
                {
                    IEnumerable<int> data = command.Substring(5).Split(", ").Select(int.Parse);
                    foreach (int number in data)
                        stack.Push(number);
                }
                else if (command == "Pop")
                {
                    if (stack.Count == 0) Console.WriteLine("No elements");
                    else stack.Pop();
                }
                command = Console.ReadLine();
            }






            for (int i = 0; i < 2; i++)
            {
                foreach (int element in stack.Where(x => x != 0))
                    Console.WriteLine(element);
            }
        }
    }
}