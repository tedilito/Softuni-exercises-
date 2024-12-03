int quantityFood = int.Parse(Console.ReadLine());
Queue<int> queue = new Queue<int>();
string[] foodToOrder = Console.ReadLine().Split();

foreach (var item in foodToOrder)
{
    queue.Enqueue(int.Parse(item));
}
int biggestOrder = int.MinValue;
foreach (var order in queue)
{
    if (order > biggestOrder)
    {
        biggestOrder = order;
    }
}
while (queue.Count != 0)
{
    if (queue.Peek() <= quantityFood)
    {
        
        quantityFood -= queue.Dequeue();
        

    }
    else
    {
        break; 
    }

}
if (queue.Count == 0)
{
    Console.WriteLine(biggestOrder);
    Console.WriteLine("Orders complete");
}
else
{
    Console.WriteLine(biggestOrder);
    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
}