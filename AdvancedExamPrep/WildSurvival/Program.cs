


Queue<int> bees = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
Stack<int> beeEaters = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));


while (beeEaters.Count > 0 && bees.Count > 0)
{
    int cuurrentBees = bees.Dequeue();
    int currentBeeEater = beeEaters.Pop();
    int attackCapacity = currentBeeEater * 7;
    if (cuurrentBees < attackCapacity)
    {
        double leftAttackers = (attackCapacity - cuurrentBees) / 7.00;
        leftAttackers = Math.Ceiling(leftAttackers);
        if (beeEaters.TryPop(out int result))
        {
            leftAttackers += result;
        }

        beeEaters.Push((int)leftAttackers);
    }
    else if (cuurrentBees > attackCapacity)
    {
        bees.Enqueue(cuurrentBees - attackCapacity);
    }
  

}
Console.WriteLine("The final battle is over!");
if (bees.Count == 0 && beeEaters.Count == 0)
{
    Console.WriteLine("But no one made it out alive!");
}
else if (beeEaters.Count == 0)
{
    Console.WriteLine($"Bee groups left: {string.Join(", ", bees)}");
}
else
{
    Console.WriteLine($"Bee-eater groups left: {string.Join(", ", beeEaters)}");
}