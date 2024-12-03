
Stack<int>  initialFuel = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> consumptionIndex = new Queue<int> (Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> needFuelAltitude = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
int i = 1; 
List<string> reachedAltitued = new List<string>();
bool hasLost = false;
while (initialFuel.Count > 0 && consumptionIndex.Count > 0)
{
     int currentFuel = initialFuel.Pop();
    int currentCosumption = consumptionIndex.Dequeue();
    int needFuel = needFuelAltitude.Dequeue();


    if (currentFuel - currentCosumption >= needFuel)
    {
        Console.WriteLine($"John has reached: Altitude {i}");
        reachedAltitued.Add($"Altitude {i++}");
    }
    else
    {
        Console.WriteLine($"John did not reach: Altitude {i}");
        hasLost = true;
        break; 
    }


}
if (!hasLost)
{
    Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
}
else if (reachedAltitued.Count == 0)
{
    Console.WriteLine("John failed to reach the top.");
    Console.WriteLine("John didn't reach any altitude.");
}
else
{
    Console.WriteLine("John failed to reach the top.");
    Console.WriteLine($"Reached altitudes: {string.Join(", ", reachedAltitued)}");
}