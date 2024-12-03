string[] input = Console.ReadLine().Split();
int numOfElements = int.Parse(input[0])
    , numOfElementsToPop = int.Parse(input[1])
    , elementToLookFor = int.Parse(input[2]);

input = Console.ReadLine().Split();
Queue<int> queue = new Queue<int>();
for (int i = 0; i < input.Length; i++)
{
    queue.Enqueue(int.Parse(input[i]));
}

for (int i = 0; i < numOfElementsToPop; i++)
{
    queue.Dequeue();
}

if (queue.Contains(elementToLookFor))
{
    Console.WriteLine("true");
}
else
{
    if (queue.Count == 0)
    {
        Console.WriteLine(0);
    }
    else
    {
        int minNumber = int.MaxValue;
        while (queue.Count != 0)
        {

            int currentElement = queue.Dequeue();
            if (currentElement < minNumber)
            {
                minNumber = currentElement;
            }
        }
        Console.WriteLine(minNumber);
    }
}