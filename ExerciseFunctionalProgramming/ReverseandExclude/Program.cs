int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
int num = int.Parse(Console.ReadLine());
ints = ints.Reverse().ToArray();
Predicate<int> predicate = n => n % num != 0;
for (int i = 0; i < ints.Length; i++)
{
	if (predicate(ints[i]))
	{
	Console.Write(ints[i] + " ");
	}
	
}
