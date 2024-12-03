
Stack<int> whiteTiles = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)));

Queue<int> greyTiles = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)));

Dictionary<string, int> locationAndUsedTiles = new Dictionary<string, int>();
locationAndUsedTiles.Add("Sink", 0);
locationAndUsedTiles.Add("Oven", 0);
locationAndUsedTiles.Add("Countertop", 0);
locationAndUsedTiles.Add("Wall", 0);
locationAndUsedTiles.Add("Floor", 0);
while (whiteTiles.Count > 0 && greyTiles.Count > 0)
{
    int currentWhiteTile = whiteTiles.Pop();
    int currentGreyTile = greyTiles.Dequeue();

    if (currentGreyTile == currentWhiteTile)
    {
        int newTile = currentWhiteTile + currentGreyTile;
        if (newTile == 40)
        {
            locationAndUsedTiles["Sink"]++;
        }
        else if (newTile == 50)
        {
            locationAndUsedTiles["Oven"]++;
        }
        else if (newTile == 60)
        {
            locationAndUsedTiles["Countertop"]++;
        }
        else if (newTile == 70)
        {
            locationAndUsedTiles["Wall"]++;
        }
        else
        {
            locationAndUsedTiles["Floor"]++;
        }
    }
    else
    {
        currentWhiteTile /= 2;
        whiteTiles.Push(currentWhiteTile);
        greyTiles.Enqueue(currentGreyTile);
    }



}

if (whiteTiles.Any())
{
    Console.WriteLine($"White tiles left: {string.Join(", ", whiteTiles)}");
}
else
{
    Console.WriteLine("White tiles left: none");
}

if (greyTiles.Any())
{
    Console.WriteLine($"White tiles left: {string.Join(", ", greyTiles)}");
}
else
{
    Console.WriteLine("Grey tiles left: none");
}

foreach (var item in locationAndUsedTiles.Where(x => x.Value != 0).OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}