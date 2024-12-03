
using System.Diagnostics;

namespace ListyIterator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //Debug.Assert(data[0] == "Create");

            ListyIterator<string> list = new ListyIterator<string>(data.Skip(1).ToList());

            string command = Console.ReadLine();
            while (command != "END")
            {
                try
                {
                    if (command == "Move") Console.WriteLine(list.Move());
                    else if (command == "HasNext") Console.WriteLine(list.HasNext());
                    else if (command == "Print") list.Print();
                    else if (command == "PrintAll")
                    {
                        Console.WriteLine(string.Join(" ",list));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                command = Console.ReadLine();

            }

        }
    }
}
