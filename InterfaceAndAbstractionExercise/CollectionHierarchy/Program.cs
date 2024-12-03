namespace CollectionHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elementsToAdd = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            List<IAddCollectionable> addcollections = new List<IAddCollectionable>();
            List<IAddRemoveCollectonable> AddRemovecollections = new List<IAddRemoveCollectonable>();
            AddCollection addCollection = new AddCollection();
            AddRemoveCollectio addRemoveCollection = new AddRemoveCollectio();
            MyList myList = new MyList();
            addcollections.Add(addCollection);
            addcollections.Add(addRemoveCollection);
            addcollections.Add(myList);
           
            AddRemovecollections.Add(addRemoveCollection);
            AddRemovecollections.Add(myList);

            foreach (var collection in addcollections)
            {
                for (int i = 0; i < elementsToAdd.Length; i++)
                {
                    Console.Write(collection.Add(elementsToAdd[i]) + " ");
                }
                Console.WriteLine();
            }


            foreach (var collection in AddRemovecollections)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(collection.Remove(elementsToAdd[i]) + " ");

                }
                Console.WriteLine();
            }
         
        }
    }
}
