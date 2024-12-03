Stack<int> packages = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> courier = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
int totalDeliveredWeight = 0;
while (packages.Count > 0 && courier.Count > 0)
{
    int currentPackage = packages.Pop();
    int currentCourier = courier.Dequeue();

    if (currentCourier >= currentPackage)
    {
        if (currentCourier > currentPackage)
        {
            currentCourier -= currentPackage * 2;
            if (currentCourier > 0)
            {
                courier.Enqueue(currentCourier);
            }
        }
        totalDeliveredWeight += currentPackage;
    }
    else
    {
        currentPackage -= currentCourier;
        packages.Push(currentPackage);
        totalDeliveredWeight += currentCourier;
    }

}
Console.WriteLine($"Total weight: {totalDeliveredWeight} kg");
if (packages.Count == 0 && courier.Count == 0)
{
    Console.WriteLine("Congratulations, all packages were delivered successfully by the couriers today.");
}
else if (packages.Count > 0 && courier.Count == 0)
{
    Console.WriteLine($"Unfortunately, there are no more available couriers to deliver the following packages:" +
        $" {string.Join(", ", packages)}");
}
else
{
    Console.WriteLine($"Couriers are still on duty: {string.Join(", ", courier)} but there are no more packages to deliver.");
}