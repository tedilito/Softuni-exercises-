

Func<string,bool> checker = n => n[0] == n.ToUpper()[0];


string[] numsSorted = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries).Where(x => checker(x)).ToArray();

foreach (var nums in numsSorted)
{
    Console.WriteLine(nums);
}