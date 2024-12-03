namespace CustomList
{
    class Program
    {
        public static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(5);
            customList.Add(6);
            customList.Add(9);
            for (int i = 0; i < customList.Count; i++)
            {
                Console.WriteLine(customList[i]);
            }
            customList.RemoveAt(0);
            customList.Contains(6);
            customList.Contains(5);
            for (int i = 0; i < customList.Count; i++)
            {
                Console.WriteLine(customList[i]);
            }
            customList.Swap(0,1);
            for (int i = 0; i < customList.Count; i++)
            {
                Console.WriteLine(customList[i]);
            }


            CustomList<string> customListString = new CustomList<string>();
            customListString.Add("Hi");
            customListString.Add("Hello");
            customListString.Add("bye");
            for (int i = 0; i < customList.Count; i++)
            {
                Console.WriteLine(customListString[i]);
            }
            customListString.RemoveAt(0);
          
            Console.WriteLine(customListString.Contains("Hi"));
            Console.WriteLine(customListString.Contains("bye"));
           
            for (int i = 0; i < customListString.Count; i++)
            {
                Console.WriteLine(customListString[i]);
            }
            customListString.Swap(0, 1);
            for (int i = 0; i < customListString.Count; i++)
            {
                Console.WriteLine(customListString[i]);
            }
        }
    }
}
