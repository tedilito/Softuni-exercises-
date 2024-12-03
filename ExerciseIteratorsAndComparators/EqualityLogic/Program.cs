namespace EqualityLogic
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // Create both sets to store Person objects
            HashSet<Person> hashSet = new HashSet<Person>();
            SortedSet<Person> sortedSet = new SortedSet<Person>();

            // Read input and add each person to both sets
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                hashSet.Add(person);
                sortedSet.Add(person);
            }

            // Print the sizes of both sets
            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}
