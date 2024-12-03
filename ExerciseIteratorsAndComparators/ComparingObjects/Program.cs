using System;

namespace ComparingObjects
{
   public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                // Input format: "{name} {age} {town}"
                string[] tokens = input.Split(' ');
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

             
                people.Add(new Person(name, age, town));
            }

            
            int n = int.Parse(Console.ReadLine());
            Person referencePerson = people[n - 1];

          
            int equalCount = 0;
            int notEqualCount = 0;

          
            foreach (var person in people)
            {
                if (person.CompareTo(referencePerson) == 0)
                {
                    equalCount++;
                }
                else
                {
                    notEqualCount++;
                }
            }

           
            if (equalCount > 1) 
            {
                Console.WriteLine($"{equalCount} {notEqualCount} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
