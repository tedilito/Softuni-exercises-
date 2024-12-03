int n = int.Parse(Console.ReadLine());

Dictionary<int,int> map = new Dictionary<int,int>();

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (!map.ContainsKey(num))
    {
        map.Add(num, 0);
    }
    map[num]++;
}

foreach (var (num,time) in map)
{
    if (time % 2 == 0)
    {
        Console.WriteLine(num);
    }
}
