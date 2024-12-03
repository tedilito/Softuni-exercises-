namespace CustomLinkedLists
{
    class Program
    {
        public static void Main(string[] args)
        {
            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.AddLast(5);
            customLinkedList.AddFirst(6);
            customLinkedList.ForEach(x => { Console.WriteLine(x); });
            customLinkedList.RemoveLast();
            Console.WriteLine(" ");
            customLinkedList.ForEach(x => { Console.WriteLine(x); });
            customLinkedList.RemoveFirst();
            
            
        }
    }
}

