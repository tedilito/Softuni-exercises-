
using System.Runtime.ExceptionServices;

Queue<int> cupCapacity = new Queue<int>();
int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
for (int i = 0; i < nums.Length; i++)
{
    cupCapacity.Enqueue(nums[i]);
}


Stack<int> bottleWithWater = new Stack<int>();

nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
for (int i = 0; i < nums.Length; i++)
{
    bottleWithWater.Push(nums[i]);
}

int wastedWater = 0;

while (bottleWithWater.Count > 0 && cupCapacity.Count > 0)
{
    int lastBottle = bottleWithWater.Pop();
    int fistCup = cupCapacity.Dequeue();


    int result = lastBottle - fistCup;
    if (result >= 0)
    {
        wastedWater += result;
    }
    else
    {

        while (result < 0)
        {
            lastBottle = bottleWithWater.Pop();
            result += lastBottle; 
        }
        wastedWater += result;
        result = 0;

    }



}
if (cupCapacity.Count > 0)
{
    Console.WriteLine($"Cups: {string.Join(" ", cupCapacity)}");
}
else
{
    Console.WriteLine($"Bottles: { string.Join(" ", bottleWithWater)}");
}

    Console.WriteLine($"Wasted litters of water: {wastedWater}");
