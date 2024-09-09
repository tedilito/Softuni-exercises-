string input;
Queue<string> market = new Queue<string>();
while ((input = Console.ReadLine()) != "End")
{
   
    if (input == "Paid")
    {
        int count = market.Count;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(market.Dequeue());
        }
            
            
        
    }
    else
    {
        market.Enqueue(input);
    }
}
Console.WriteLine($"{market.Count} people remaining.");