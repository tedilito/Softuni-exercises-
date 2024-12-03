Queue<int> textile = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));


Stack<int> medicaments = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Dictionary<string, int> TotalItems = new Dictionary<string, int>();
TotalItems.Add("Patch", 0);
TotalItems.Add("Bandage", 0);
TotalItems.Add("MedKit", 0);

while (textile.Count > 0 && medicaments.Count > 0)
{
    int curretnTextile = textile.Dequeue();
    int currentMedicaments = medicaments.Pop();

    int sum = currentMedicaments + curretnTextile;

    if (sum == 30)
    {
        TotalItems["Patch"]++;
    }
    else if (sum == 40)
    {
        TotalItems["Bandage"]++;
    }
    else if (sum == 100)
    {
        TotalItems["MedKit"]++;
    }
    else if (sum > 100)
    {
        TotalItems["MedKit"]++;
        sum -= 100;

        medicaments.Push(medicaments.Pop() + sum);

    }
    else
    {
        if (medicaments.Count > 0)
        {
            medicaments.Push(currentMedicaments + 10);
        }
        else
        {
            medicaments.Push(10);
        }
      
    }

}


if (!textile.Any() && !medicaments.Any())
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (!textile.Any())
{
    Console.WriteLine("Textiles are empty.");
}
else
{
    Console.WriteLine("Medicaments are empty.");
}

foreach (var item in TotalItems.Where(x => x.Value > 0).OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

if (medicaments.Count > 0)
{
    Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}"); 
}

if (textile.Count > 0)
{
    Console.WriteLine($"Textiles left: {string.Join(", ", textile)}");
}