string[] input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int m = int.Parse(input[1]);

HashSet<int> first = new HashSet<int>();
HashSet<int> second = new HashSet<int>();

first = RadSet(m);
second = RadSet(n);



List<int> list = new List<int>();
foreach(var item in first)
{
    if (second.Contains(item))
    {
        list.Add(item);
    }
}
Console.WriteLine(string.Join(" ", list));

static HashSet<int> RadSet(int n)
{
    HashSet<int> result = new HashSet<int>();
    for (global::System.Int32 i = 0; i < n; i++)
    {
        int num = int.Parse(Console.ReadLine());
        result.Add(num);
    }
    return result;
}