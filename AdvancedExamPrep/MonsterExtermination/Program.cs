Queue<int> monsterArmor = new Queue<int>(Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Stack<int> SoldierImpact = new Stack<int>(Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
int countKilledMonsters = 0;
while (monsterArmor.Count > 0 && SoldierImpact.Count > 0)
{
    int currentMonster = monsterArmor.Dequeue();
    int currentStrike = SoldierImpact.Pop();

    if (currentStrike >= currentMonster)
    {
        countKilledMonsters++;
        currentStrike -= currentMonster;
        if (currentStrike > 0)
        {
            
                if (SoldierImpact.Count > 0)
                {
                    
                    
                    SoldierImpact.Push(SoldierImpact.Pop() + currentStrike);
                }
                else if (SoldierImpact.Count == 0)
                {
                    SoldierImpact.Push(currentStrike);
                }
                
            
           
        }

    }
    else
    {
        currentMonster -= currentStrike;
        monsterArmor.Enqueue(currentMonster);
    }
}

if (monsterArmor.Count == 0)
{
    Console.WriteLine("All monsters have been killed!");
}

if (SoldierImpact.Count == 0)
{
    Console.WriteLine("The soldier has been defeated.");
}

Console.WriteLine($"Total monsters killed: {countKilledMonsters}");