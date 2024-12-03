int n  = int.Parse(Console.ReadLine());
HashSet<string> set = new HashSet<string>();
List<string> list = new List<string>();
for (int i = 0; i < n; i++)
{
    string names = Console.ReadLine();
    if (set.Add(names))
    {
       list.Add(names);
    }
}
foreach (string name in list)
{
    Console.WriteLine(name);
}