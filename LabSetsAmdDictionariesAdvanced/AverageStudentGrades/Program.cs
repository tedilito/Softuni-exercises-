using System.ComponentModel;

int studentsCount = int.Parse(Console.ReadLine());
Dictionary<string,List<decimal>> students = new Dictionary<string,List<decimal>>();

for (int i = 0; i < studentsCount; i++)
{
    string[] arguments = Console.ReadLine().Split();
    string name = arguments[0];
    decimal grade = decimal.Parse(arguments[1]);
    if (students.ContainsKey(name))
    {
        students[arguments[0]].Add(grade);
    }
    else
    {
        students.Add(name, new List<decimal>());
        students[name].Add(grade);
    }
}
foreach (var student in students)
{
    string[] grades = student.Value.Select(grade => $"{grade:f2}").ToArray();
    Console.WriteLine($"{student.Key} -> {string.Join(" ",grades)} (avg: {student.Value.Average():F2})");
}