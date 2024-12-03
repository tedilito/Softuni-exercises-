Stack<int> amountOfMoney = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> pricesOfFoods = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int countEaten = 0;

while (pricesOfFoods.Count > 0 && amountOfMoney.Count > 0)
{
    int currentAmountMoney = amountOfMoney.Pop();
    int currentPriceFood = pricesOfFoods.Dequeue();

    if (currentAmountMoney == currentPriceFood)
    {
        countEaten++;
    }
    else if (currentAmountMoney > currentPriceFood)
    {
        countEaten++;
        currentAmountMoney -= currentPriceFood;
        int addedAmountOfMoney = currentAmountMoney;
        if (amountOfMoney.Count > 0)
        {
             addedAmountOfMoney += amountOfMoney.Pop();
        }
      
       
        amountOfMoney.Push(addedAmountOfMoney);
    }

}

if (countEaten >= 4)
{
    Console.WriteLine($"Gluttony of the day! Henry ate {countEaten} foods.");
}
else if (countEaten == 0)
{
    Console.WriteLine("Henry remained hungry. He will try next weekend again.");
}
else
{
    if (countEaten == 1)
    {
        Console.WriteLine($"Henry ate: {countEaten} food.");
    }
    else
    {
        Console.WriteLine($"Henry ate: {countEaten} foods.");
    }
}