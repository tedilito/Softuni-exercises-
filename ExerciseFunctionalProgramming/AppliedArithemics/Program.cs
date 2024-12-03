Func<List<int>, List<int>> func = null;  
List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

string input;
while ((input = Console.ReadLine()) != "end")
{

    if (input == "add")
    {
        func = nums => nums.Select(x => x + 1).ToList();
        list = func(list);
    }
    else if (input == "multiply")
    {
        func = nums => nums.Select(x => x * 2).ToList();
        list = func(list);
    }
    else if (input == "subtract")
    {
        func = nums => nums.Select(x => x - 1).ToList();
        list = func(list);
    }
    else if (input == "print")
    {
        Console.WriteLine(string.Join(" ", list));
        
    }
   
}



