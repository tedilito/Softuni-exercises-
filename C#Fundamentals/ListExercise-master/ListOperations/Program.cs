

using System.Diagnostics.CodeAnalysis;

namespace ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();
                switch (arguments[0])
                {
                    case "Add":
                        int num = int.Parse(arguments[1]);
                        list.Add(num);
                        break;

                    case "Insert":
                        num = int.Parse(arguments[1]);
                        int index = int.Parse(arguments[2]);

                        if (index >= 0 && index <= list.Count - 1)
                        {
                            list.Insert(index, num);

                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Remove":
                        index = int.Parse(arguments[1]);
                        if (index >= 0 && index <= list.Count - 1)
                        {
                            list.RemoveAt(index);

                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Shift":
                        string direction = arguments[1];
                        int count = int.Parse(arguments[2]);
                     
                        switch (direction)
                        {
                            case "left":
                                for (int i = 0; i < count; i++)
                                {
                                    list.Add(list[0]);
                                    list.Remove(list[0]);
                                }


                                break;
                            case "right":
                                for (int i = 0; i < count; i++)
                                {
                                    list.Insert(0, list[list.Count - 1]);
                                    list.RemoveAt(list.Count - 1);
                                }

                                break;

                        }
                        break;


                }
            }
            Console.WriteLine(string.Join(" ", list));
        }


    }
}