Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] commands = Console.ReadLine().Split(" -> ");
    string color = commands[0];
    string[] clothes = commands[1].Split(",");
    if (!wardrobe.ContainsKey(color))
    {
        string cloth = clothes[0];
        wardrobe.Add(color, new Dictionary<string, int>());
    }
    for (global::System.Int32 j = 0; j < clothes.Length; j++)
    {
        if (!wardrobe[color].ContainsKey(clothes[j]))
        {
            wardrobe[color].Add(clothes[j], 1);

        }
        else
        {
            wardrobe[color][clothes[j]]++;
        }
    }
}

string[] itemsToLookFor = Console.ReadLine().Split();
string colorToLookFor = itemsToLookFor[0];
string cloht = itemsToLookFor[1];

foreach (var (colors,cloth) in wardrobe)
{
    Console.WriteLine($"{colors} clothes:");
    foreach (var (clothes,count) in cloth)
    {
        if (colorToLookFor == colors && clothes == cloht)
        {
            Console.WriteLine($"* {clothes} - {count} (found!)");
        }
        else
        {
            Console.WriteLine($"* {clothes} - {count}");
        }
    }
}


