int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
Func<int,int,bool> minFunc = (a,b) => a < b;

int minNum = int.MaxValue;

for (int i = 0; i < nums.Length; i++)
{
    
    if (minFunc(nums[i], minNum))
    {
        minNum = nums[i];
    }
}
Console.WriteLine(minNum);