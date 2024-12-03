Queue<int> time = new Queue<int>(Console.ReadLine().Split().Select(x => int.Parse(x)));
Stack<int> numOfTaks = new Stack<int>(Console.ReadLine().Split().Select(x => int.Parse(x)));

Dictionary<string, int> patki = new Dictionary<string, int>();
patki.Add("Darth Vader Ducky",0);
patki.Add("Thor Ducky", 0);
patki.Add("Big Blue Rubber Ducky", 0);
patki.Add("Small Yellow Rubber Ducky", 0);

while (time.Count > 0 && numOfTaks.Count > 0 )
{
    int currentTime = time.Dequeue(); 
    int currentNumOfTasks = numOfTaks.Pop();

   int timeNeed = currentTime * currentNumOfTasks;

    if (timeNeed >= 0 && timeNeed <= 60)
    {
        patki["Darth Vader Ducky"]++;
    }
    else if (timeNeed >= 61 && timeNeed <= 120)
    {
        patki["Thor Ducky"]++;
    }
    else if (timeNeed >= 121 && timeNeed <= 180)
    {
        patki["Big Blue Rubber Ducky"]++;

    }
    else if (timeNeed >= 181 && timeNeed <= 240)
    {
        patki["Small Yellow Rubber Ducky"]++;
    }
    else
    {
        currentNumOfTasks -= 2;
        numOfTaks.Push(currentNumOfTasks);
       time.Enqueue(currentTime);
       
    }

}
Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");

foreach (var patka in patki)
{
    Console.WriteLine($"{patka.Key}: {patka.Value}");
}