int[] sequenceInBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> stack = new Stack<int>(sequenceInBox);
int capacityOfRack = int.Parse(Console.ReadLine());
int capacityReached = 0;
int numOfRacks = 1;
while (stack.Count != 0 )
{
    int currentCloth = stack.Pop();
    capacityReached += currentCloth;
    if (capacityReached > capacityOfRack )
    {
        capacityReached = currentCloth;
        numOfRacks++;
    }
    else if (capacityReached == capacityOfRack && stack.Count != 0)
    {
        numOfRacks++;
        capacityReached = 0; 
    }

}
Console.WriteLine(numOfRacks);