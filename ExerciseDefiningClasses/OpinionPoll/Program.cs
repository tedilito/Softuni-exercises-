using OpinionPoll;
using System.Reflection.PortableExecutable;
int n = int.Parse(Console.ReadLine());

Person[] people = new Person[n];
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    Person person = new Person(input[0], int.Parse(input[1]));
    people[i] = person;
    
   
   
}
foreach (var item in people.Where(p => p.Age > 30).OrderBy(x => x.Name))
{
    Console.WriteLine($"{item.Name} - {item.Age}");
}