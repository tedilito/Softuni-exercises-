Stack<int> strenghtRequired = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(x => int.Parse(x)));

Queue<int> accuracyNeeded = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(x => int.Parse(x)));
int countScoredGoals = 0;
while (strenghtRequired.Any() && accuracyNeeded.Any())
{
    int currentStrenght = strenghtRequired.Peek();
    int currentAccuracy = accuracyNeeded.Peek();
    int sum = currentStrenght+currentAccuracy;

    if (sum == 100)
    {
        countScoredGoals++;
        accuracyNeeded.Dequeue();
        strenghtRequired.Pop();
    }
    else if (sum < 100)
    {
        if (currentStrenght < currentAccuracy)
        {
            strenghtRequired.Pop();
        }
        else if (currentStrenght > currentAccuracy)
        {
            accuracyNeeded.Dequeue();
        }
        else
        {
            strenghtRequired.Push(strenghtRequired.Pop() + currentAccuracy);
            accuracyNeeded.Dequeue();

        }
    }
    else
    {
        strenghtRequired.Push(strenghtRequired.Pop() - 10);
        accuracyNeeded.Enqueue(accuracyNeeded.Dequeue());
    }

}

if (countScoredGoals == 3)
{
    Console.WriteLine("Paul scored a hat-trick!");
}
else if (countScoredGoals > 3)
{
    Console.WriteLine("Paul performed remarkably well!");
}
else if (countScoredGoals == 0)
{
    Console.WriteLine("Paul failed to score a single goal.");
}

if (countScoredGoals > 0 && countScoredGoals < 3)
{
    Console.WriteLine("Paul failed to make a hat-trick.");
}
if (countScoredGoals > 0)
{
    Console.WriteLine($"Goals scored: {countScoredGoals}");
}



if (strenghtRequired.Any())
{
    Console.WriteLine($"Strength values left: {string.Join(", ", strenghtRequired)}");
}
if (accuracyNeeded.Any())
{
    Console.WriteLine($"Accuracy values left: {string.Join(", ", accuracyNeeded)}");
}