int[] numsSorted = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();

int sum = numsSorted.Sum();
int count = numsSorted.Count();

Console.WriteLine(count);
Console.WriteLine(sum);
