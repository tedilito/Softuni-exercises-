Stack<int> stack = new Stack<int>();
int numOfQueries = int.Parse(Console.ReadLine());
for (int i = 0; i < numOfQueries; i++)
{
    string input = Console.ReadLine();
    if (input[0] == '1')
    {
        string[] arguments = input.Split();
        int num = int.Parse(arguments[1]);
        stack.Push(num);
    }
    else if (input[0] == '2')
    {
        if (stack.Count != 0)
        {
            stack.Pop();
        }
        
    }
    else if (input == "3")
    {
        if (stack.Count > 0)
        {
            Console.WriteLine(stack.Max());
        }
    }
    else if (input == "4")
    {
        if (stack.Count > 0)
        {
            Console.WriteLine(stack.Min());
        }
    }
}
Console.WriteLine(string.Join(", ", stack));