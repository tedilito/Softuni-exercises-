
Stack<int> worms = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(x => int.Parse(x)));


Queue<int> holes = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(x => int.Parse(x)));

int countMatches = 0;
int allWorms = worms.Count;
while (worms.Count > 0 && holes.Count > 0)
{
    int currentWorm = worms.Pop();
    int currentHole = holes.Dequeue();

    if (currentHole == currentWorm)
    {
        countMatches++;
    }
    else 
    {
        if (currentWorm - 3> 0)
        {
            worms.Push(currentWorm - 3);
        }
        
    }

}


if (countMatches > 0)
{
    Console.WriteLine($"Matches: {countMatches}");
}
else
{
    Console.WriteLine("There are no matches.");
}

if (!worms.Any() && countMatches == allWorms)
{
    Console.WriteLine("Every worm found a suitable hole!");
}
else if (!worms.Any() && countMatches != allWorms)
{
    Console.WriteLine("Worms left: none");
}
else if (worms.Any())
{
    Console.WriteLine($"Worms left: {string.Join(", ", worms)}");
}


if (holes.Any())
{
    Console.WriteLine($"Holes left: {string.Join(", ", holes)}");
}
else
{
    Console.WriteLine("Holes left: none");
}