int n = int.Parse(Console.ReadLine());

List<int> dividers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

Func<int, bool> isDivisibleByAll = num => dividers.All(d => num % d == 0);

List<int> divisibleNumbers = Enumerable
    .Range(1, n)
    .Where(isDivisibleByAll)
    .ToList();

Console.WriteLine(string.Join(" ", divisibleNumbers));