Queue<int> contestats = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Stack<int> piesNumOfPieces = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

while (contestats.Count > 0 && piesNumOfPieces.Count > 0)
{
    int currentContestant = contestats.Dequeue();
    int currentPiePieces = piesNumOfPieces.Pop();

    if (currentContestant >= currentPiePieces)
    {
        currentContestant -= currentPiePieces;
        if (currentContestant > 0)
        {
            contestats.Enqueue(currentContestant);
        }

    }
    else
    {
        currentPiePieces -= currentContestant;

        if (piesNumOfPieces.Count == 0)
        {
            piesNumOfPieces.Push(currentPiePieces);
        }
        else if (currentPiePieces == 1)
        {
            int addedValueToPie = piesNumOfPieces.Pop() + currentPiePieces;
            piesNumOfPieces.Push(addedValueToPie);
        }
        else
        {
            piesNumOfPieces.Push(currentPiePieces);
        }
    }

}
if (piesNumOfPieces.Count == 0 && contestats.Count > 0)
{
    Console.WriteLine("We will have to wait for more pies to be baked!");
    Console.WriteLine($"Contestants left: {string.Join(", ", contestats)}");
}
else if (contestats.Count == 0 && piesNumOfPieces.Count == 0)
{
    Console.WriteLine("We have a champion!");
}
else
{
    Console.WriteLine("Our contestants need to rest!");
    Console.WriteLine($"Pies left: {string.Join(", ", piesNumOfPieces)}");
}