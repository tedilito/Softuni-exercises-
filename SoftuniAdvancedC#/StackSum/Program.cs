Stack<int> stack = new Stack<int>();
int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
foreach (var item in nums)
{
    stack.Push(item);
}
string input;
while ((input = Console.ReadLine().ToLower()) != "end")
{
    string[] commdans = input.Split();
    if (commdans[0].ToLower() == "add" )
    {
        int num1 = int.Parse(commdans[1]);
        int num2 = int.Parse(commdans[2]);
        stack.Push(num1);
        stack.Push(num2);
    }
    else
    {
        int count = int.Parse(commdans[1]);
        if (count > stack.Count)
        {
            continue;
        }
        else
        {
            for (global::System.Int32 i = 0; i < count; i++)
            {
                stack.Pop();
            }
        }
    }
       
}
Console.WriteLine($"Sum: {stack.Sum()}");