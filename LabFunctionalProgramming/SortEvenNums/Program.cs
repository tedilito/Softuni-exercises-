int[] numsSorted = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .Where(x => x % 2 == 0)
    .OrderBy(x => x)
    .ToArray();

Console.WriteLine(string.Join(", ", numsSorted));