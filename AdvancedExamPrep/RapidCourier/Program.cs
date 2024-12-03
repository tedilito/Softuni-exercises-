Stack<int> packages = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
Queue<int> couriers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));


int totalDeliveredWeight = 0; 
while (packages.Count > 0 && couriers.Count > 0)
{
    int currentPackage = packages.Pop();
    int currentCourier = couriers.Dequeue();

    if (currentCourier >= currentPackage)
    {
        totalDeliveredWeight += currentPackage;
        if (currentCourier - 2 * currentPackage > 0)
        {
            couriers.Enqueue(currentCourier - 2 * currentPackage);
        }
    }
    else
    {
        currentPackage -= currentCourier;
        packages.Push(currentPackage);
        totalDeliveredWeight += currentCourier;
    }
}

Console.WriteLine($"Total weight: {totalDeliveredWeight} kg");
if (!packages.Any() && !couriers.Any())
{
    Console.WriteLine( "Congratulations, all packages were delivered successfully by the couriers today.");
}
else if (packages.Any() && !couriers.Any())
{
    Console.WriteLine ($"Unfortunately, there are no more available couriers to deliver the following packages: {string.Join(", ", packages)}");
}
else
{
    Console.WriteLine($"Couriers are still on duty: {string.Join(", ", couriers)} but there are no more packages to deliver.");
}