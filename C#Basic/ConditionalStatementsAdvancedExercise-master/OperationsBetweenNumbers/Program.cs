

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
double result = 0;
char operation = char.Parse(Console.ReadLine());

switch (operation)
{
	case '+':
		result = num1 + num2;
		break;

	case '-':
		result = num1 - num2;

		break;

	case '*':
		result = num1 * num2;
		break;

	
}
if (operation == '+' || operation == '-' || operation == '*'  )
{
    if (result % 2 == 0)
    {
        Console.WriteLine($"{num1} {operation} {num2} = {result} - even");
    }
	else
	{
		Console.WriteLine($"{num1} {operation} {num2} = {result} - odd");
	}
}

if (num2 == 0)
{
    Console.WriteLine($"Cannot divide {num1} by zero");
}
else if (operation == '/')
{
    result = (double)num1 / num2;
    Console.WriteLine($"{num1} {operation} {num2} = {result:f2}");
}
else if (operation == '%')
{
    result = num1 % num2;
    Console.WriteLine($"{num1} {operation} {num2} = {result}");
}
