

int n = int.Parse(Console.ReadLine());
List<Person> list = new List<Person>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ");
    string name = input[0];
    int age = int.Parse(input[1]);

    Person person = new Person()
    {
        Name = name,
        Age = age
    };
    list.Add(person);
}
string condition = Console.ReadLine();
int ageTreshhold = int.Parse(Console.ReadLine());
string format = Console.ReadLine();
Func<Person, bool> filer = null;

switch (condition)
{
    case "older":
        filer = person => person.Age >= ageTreshhold; break;
    case "younger":
        filer = person => person.Age < ageTreshhold; break;


    default:
        break;
}


list = FilterPeople(list, filer);
Func<Person, string> formater = null;
switch (format)
{
    case "name":
        formater = person => person.Name ; break;
    case "age":
        formater = person => person.Age.ToString(); break;

    case "name age":
        formater =person => $"{person.Name} - {person.Age.ToString()}";
        break;
}

PrintStud(list, formater);


void PrintStud(List<Person> list, Func<Person, string> formatter)
{
    foreach (Person person in list)
    {
        Console.WriteLine(formatter(person));
    }
}

List<Person> FilterPeople(List<Person> list, Func<Person,bool> filter)
{
    return list.Where(filter).ToList();
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}