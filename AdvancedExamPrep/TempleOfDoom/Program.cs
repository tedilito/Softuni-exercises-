using System.Linq;

Queue<int> tools = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Stack<int> substances = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

List<int> chalenges = new List<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));


while (tools.Count > 0 && substances.Count > 0)
{
    int currentTool = tools.Dequeue(); 
    int currentSubstances = substances.Pop();
    if (chalenges.Any(x => x == currentTool * currentSubstances))
    {
        chalenges.Remove(chalenges.Where(x => x == currentTool * currentSubstances).FirstOrDefault());
    }
    else
    {
        currentTool++; 
        tools.Enqueue(currentTool);
        currentSubstances--;
        if (currentSubstances > 0)
        {
            substances.Push(currentSubstances);
        }
    }
}
if (chalenges.Count > 0 )
{
    Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
}
else if (chalenges.Count == 0 )
{
    Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
}

if (tools.Count > 0)
{
    Console.WriteLine("Tools: " + string.Join(", ",tools ));
}


if (substances.Count > 0)
{
    Console.WriteLine("Substances: " + string.Join(", ", substances));
}

if (chalenges.Count > 0)
{
    Console.WriteLine("Challenges: " + string.Join(", ", chalenges));
}