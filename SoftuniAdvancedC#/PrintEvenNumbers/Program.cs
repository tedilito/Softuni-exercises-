int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> evenNums = new Queue<int>();
foreach (var item in nums)
{
    if (item % 2 == 0)
    {
        evenNums.Enqueue(item);
    }
    
}
Console.WriteLine(string.Join(", ", evenNums));