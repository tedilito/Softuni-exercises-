string input = Console.ReadLine();
Stack<char> stack = new Stack<char>();
foreach (char ch in input)
{
    stack.Push(ch);
}
string result = string.Empty; 
foreach (var item in stack)
{
    result += item;
}
Console.WriteLine(result);