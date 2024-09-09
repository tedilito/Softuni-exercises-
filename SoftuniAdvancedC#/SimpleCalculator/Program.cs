string[] input = Console.ReadLine().Split();

Stack<string> equation = new Stack<string>();
for (int i = input.Length - 1; i >= 0; i--)
{
    equation.Push(input[i]);
}

int result = 0;
while (equation.Count != 1 )
{
    int firstNum = int.Parse(equation.Pop());
    char op = char.Parse(equation.Pop());
    int secondNum = int.Parse(equation.Pop());
    if (op == '+')
    {
        equation.Push((firstNum + secondNum).ToString());
    }
    else
    {
        if (firstNum > secondNum)
        {
            equation.Push((firstNum - secondNum).ToString());
        }
        else
        {
            equation.Push((secondNum - firstNum).ToString());
        }
    }
}
result = int.Parse(equation.Pop());
Console.WriteLine(result);