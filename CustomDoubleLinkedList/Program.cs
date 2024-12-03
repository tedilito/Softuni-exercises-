
namespace CustomDoublyLinkedList
{
    class Program
    {
        static void Main()
        {
            CustomDoublyLinkedList<int> list = new CustomDoublyLinkedList<int>();

            list.AddFirst(10);
            list.AddLast(20);
            list.AddFirst(5);

            Console.WriteLine("Initial List:");
            PrintList(list); // Should print: 5, 10, 20

            Console.WriteLine("\nAfter RemoveFirst:");
            list.RemoveFirst(); // Removes 5
            PrintList(list); // Should print: 10, 20

            Console.WriteLine("\nAfter RemoveLast:");
            list.RemoveLast(); // Removes 20
            PrintList(list); // Should print: 10

            Console.WriteLine("\nAfter RemoveFirst (Empty List):");
            list.RemoveFirst(); // Removes 10 (empty list)
            PrintList(list); // Should print: List is empty
        }

        static void PrintList(CustomDoublyLinkedList<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("List is empty.");
            }
            else
            {
                list.ForEach(item => Console.Write(item + " "));
                Console.WriteLine();
            }
            Console.WriteLine("Count: " + list.Count);
            Console.WriteLine("Head: " + (list.Head != null ? list.Head.Value.ToString() : "null"));
            Console.WriteLine("Tail: " + (list.Tail != null ? list.Tail.Value.ToString() : "null"));
        }
    }
}


    
