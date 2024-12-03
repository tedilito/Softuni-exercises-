Queue<double> water = new Queue<double>(Console.ReadLine().Split().Select(double.Parse));
Stack<double> flour = new Stack<double>(Console.ReadLine().Split().Select(double.Parse));
Dictionary<string, int> bakedGoods = new Dictionary<string, int>()
{
    {"Croissant",0},
    {"Muffin",0},
    {"Baguette",0},
    {"Bagel",0}
};

while (water.Count > 0 && flour.Count > 0)
{
    double currentWater = water.Dequeue();
    double currentFlour = flour.Pop();
    double sum = currentFlour + currentWater;
    double waterRatio = (currentWater * 100) / sum;
    double FlourRatio = 100 - waterRatio;

    if (waterRatio == 40 && FlourRatio == 60)
    {
        bakedGoods["Muffin"]++;
    }
    else if (waterRatio == 30 && FlourRatio == 70  )
    {
        bakedGoods["Baguette"]++;
    }
    else if (waterRatio == 20 && FlourRatio == 80)
    {
        bakedGoods["Bagel"]++;
    }
    else if (waterRatio == 50 && FlourRatio == 50)
    {
        bakedGoods["Croissant"]++;
    }
    else
    {
        double difference = currentFlour - currentWater;
        currentFlour -= difference;
        flour.Push(difference);
        bakedGoods["Croissant"]++;

    }

}
foreach (var item in bakedGoods.Where(x => x.Value != 0).OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}

if (water.Any())
{
    Console.WriteLine($"Water left: {string.Join(", ", water)}");
}
else
{
    Console.WriteLine("Water left: None");
}

if (flour.Any())
{
    Console.WriteLine($"Flour left: {string.Join(", ", flour)}");
}
else
{
    Console.WriteLine("Flour left: None");
}