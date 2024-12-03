using System.Collections;

Stack<int> worms = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> holes = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int countMatches = 0;
bool hasSuitableHole = true;
while (worms.Count > 0 && holes.Count > 0)
{
    int currentWorms = worms.Pop();
    int currentHole = holes.Dequeue();

    if (currentHole != currentWorms)
    {
        hasSuitableHole = false;
        currentWorms -= 3;
        if (currentWorms > 0)
        {
            worms.Push(currentWorms);
        }
    }
    else
    {
        countMatches++;
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

if (worms.Count == 0 & hasSuitableHole)
{
    Console.WriteLine("Every worm found a suitable hole!");
}
else if (worms.Count == 0 & !hasSuitableHole)
{
    Console.WriteLine("Worms left: none");
}
else
{
    Console.WriteLine($"Worms left: {string.Join(", ", worms)}");
}

if (holes.Count == 0)
{
    Console.WriteLine("Holes left: none");
}
else
{
    Console.WriteLine($"Holes left: {string.Join(", ", holes)}");
}