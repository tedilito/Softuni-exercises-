int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
int startNum = nums[0], endNum = nums[1];   
string evenOrOdd = Console.ReadLine();

Predicate<int> isEvenOrOdd = null;

switch (evenOrOdd)
{




	case "even":
		isEvenOrOdd = x => x % 2 == 0; 
		break;

	case "odd":
        isEvenOrOdd = x => x % 2 != 0;
        break; 

}
for (int i = startNum; i < endNum; i++)
{
    if (isEvenOrOdd(i))
    {
        Console.Write(i + " ");
    }
}
