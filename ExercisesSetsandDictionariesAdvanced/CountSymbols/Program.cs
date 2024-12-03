string input = Console.ReadLine();
Dictionary<char,int> map = new Dictionary<char,int>();

for (int i = 0; i < input.Length; i++)
{
	if (!map.ContainsKey(input[i]))
	{
		map.Add(input[i], 0);
	}
	map[input[i]]++;
}
foreach ( var (chars, times) in map.OrderBy(x => x.Key))
{
    Console.WriteLine($"{chars}: {times} time/s");
}
