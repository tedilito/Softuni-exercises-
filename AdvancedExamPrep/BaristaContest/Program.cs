Queue<int> coffeeQuantity = new Queue<int> (Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(x => int.Parse(x)));

Stack<int> milkQuantity = new Stack<int>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(x => int.Parse(x)));

Dictionary<string, int> coffeeDrinksCound = new Dictionary<string, int>();
coffeeDrinksCound.Add("Cortado", 0);
coffeeDrinksCound.Add("Espresso", 0);
coffeeDrinksCound.Add("Capuccino", 0);
coffeeDrinksCound.Add("Americano", 0);
coffeeDrinksCound.Add("Latte", 0);


while (coffeeQuantity.Count > 0 && milkQuantity.Count > 0)
{
    int curentCoffee = coffeeQuantity.Dequeue();
    int currentMilk = milkQuantity.Pop();
    int sum = curentCoffee + currentMilk;
    if (sum == 50)
    {
        coffeeDrinksCound["Cortado"]++;


    }
    else if (sum == 75)
    {
        coffeeDrinksCound["Espresso"]++;
    }
    else if (sum == 100)
    {
        coffeeDrinksCound["Capuccino"]++;
    }
    else if (sum == 150)
    {
        coffeeDrinksCound["Americano"]++;
    }
    else if (sum == 200)
    {
        coffeeDrinksCound["Latte"]++;
    }
    else
    {
        milkQuantity.Push(currentMilk - 5);
    }

}



if (coffeeQuantity.Count == 0 && milkQuantity.Count == 0)
{
    Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
}
else
{
    Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
}

if (coffeeQuantity.Any())
{
    Console.WriteLine($"Coffee left: {string.Join(", ", coffeeQuantity)}");
}
else
{
    Console.WriteLine("Coffee left: none");
}


if (milkQuantity.Any())
{
    Console.WriteLine($"Milk left: {string.Join(", ", milkQuantity)}");
}
else
{
    Console.WriteLine("Milk left: none");
}


foreach (var coffeeMade in coffeeDrinksCound.Where(x => x.Value > 0).OrderBy(x => x.Value).ThenByDescending(x => x.Key))
{
    Console.WriteLine($"{coffeeMade.Key}: {coffeeMade.Value}");
}
