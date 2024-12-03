Stack<int> foodPortions  = new Stack<int>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> dailyStamina = new Queue<int>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));


Dictionary<string,int> mountains = new Dictionary<string,int>();
mountains.Add("Vihren", 80);
mountains.Add("Kutelo", 90);
mountains.Add("Banski Suhodol", 100);
mountains.Add("Polezhan", 60);
mountains.Add("Kamenitza", 70);
string[] mountainsNames = new string[]
{
    "Vihren",
    "Kutelo",
    "Banski Suhodol",
    "Polezhan",
    "Kamenitza"

};

int countClimbed = 0;
bool hasClimbedAll = false;
int i = 0;
while (foodPortions.Count > 0 && dailyStamina.Count > 0 )
{
    int currentFood = foodPortions.Pop();
    int currentStamina = dailyStamina.Dequeue();
   
    if (currentFood + currentStamina >= mountains[mountainsNames[i]])
    {
        mountains[mountainsNames[i]] = 1;
        i++;
        if (i == 5)
        {
            hasClimbedAll = true;
            break; 
        }
    }
  

}


if (hasClimbedAll)
{
    Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
}
else
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
}

if (mountains.Any(x => x.Value == 1))
{
    Console.WriteLine("Conquered peaks:");
    foreach (var mointain in mountains.Where(x => x.Value == 1))
    {
        Console.WriteLine(mointain.Key);

    }
}

