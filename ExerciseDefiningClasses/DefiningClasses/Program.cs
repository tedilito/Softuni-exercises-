using System.Net.Http.Headers;
using System.Net.Security;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person()
                {
                    Name = name,
                    Age = age
                };
                family.AddMember(person);
            }
            Person oldestPerson = family.GetOldestMember();
            Console.Write(oldestPerson.Name + " ");
            Console.Write(oldestPerson.Age);
            

        }
    }
}