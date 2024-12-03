List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

//int[] sorted = nums.OrderDescending().Take(3).ToArray();
int[] sorted = nums.OrderByDescending(n => n).ToArray();


if (nums.Count >= 3)
{
    for (global::System.Int32 i = 0; i < 3; i++)
    {
        Console.Write(sorted[i] + " ");
    }
}
else
{
    for (global::System.Int32 i = 0; i < sorted.Length; i++)
    {
        Console.Write(sorted[i] + " ");
    }
}


