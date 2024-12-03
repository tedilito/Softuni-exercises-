
string[] input = Console.ReadLine().Split();
int numOfElemnts = int.Parse(input[0])
    , numOfElementsToPop = int.Parse(input[1])
    , elementToLookFor = int.Parse(input[2]);
Stack<int> numbers = new Stack<int>();
input = Console.ReadLine().Split();
for (int i = 0; i < input.Length; i++)
{
    numbers.Push(int.Parse(input[i]));
}

for (int i = 0; i < numOfElementsToPop; i++)
{
    numbers.Pop();
}

if (numbers.Contains(elementToLookFor))
{
    Console.WriteLine("true");
}
else
{
    if (numbers.Count == 0)
    {
        Console.WriteLine(0);
    }
    else
    {
        Action<Stack<int>> printSmallest = s => Console.Write(s.Min());
        printSmallest(numbers);
    }
   
}