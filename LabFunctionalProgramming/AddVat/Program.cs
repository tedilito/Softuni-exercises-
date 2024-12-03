Func<double, double> AddVat = x => x += x *= 0.2;


double[] prices = Console.ReadLine()
    .Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse)
    .Select(AddVat)
    .ToArray();

foreach (var price in prices)
{
    Console.WriteLine($"{price:f2} ");
}