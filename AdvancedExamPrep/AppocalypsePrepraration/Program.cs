Queue<int> textile = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Stack<int> medicaments = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Dictionary<string, int> ItemsCount = new Dictionary<string, int>
{
    { "Patch", 0 },
    {"Bandage",0 },
    {"MedKit",0 }
};



while (textile.Count > 0 && medicaments.Count > 0)
{
    int currentTextile = textile.Dequeue();
    int currentMedicament = medicaments.Pop();
    int sum = currentMedicament + currentTextile;
    if (sum == 30)
    {
        ItemsCount["Patch"]++;
    }
    else if (sum == 40)
    {
        ItemsCount["Bandage"]++;
    }
    else if (sum == 100)
    {
        ItemsCount["MedKit"]++;
    }
    else if (sum > 100)
    {
        ItemsCount["MedKit"]++;
        sum -= 100;
        if (medicaments.Count > 0)
        {
            medicaments.Push(medicaments.Pop() + sum);
        }
        else
        {
            medicaments.Push(sum);
        }
    }
    else
    {
        medicaments.Push(currentMedicament + 10);
    }

}

if (!medicaments.Any() && !textile.Any())
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (!medicaments.Any())
{
    Console.WriteLine("Medicaments are empty.");
}
else 
{
    Console.WriteLine("Textiles are empty.");
}

foreach (var item in ItemsCount.Where(x => x.Value > 0).OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

if (medicaments.Any())
{
    Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
}

if (textile.Any())
{
    Console.WriteLine($"Textiles left: {string.Join(", ", textile)}");
}
