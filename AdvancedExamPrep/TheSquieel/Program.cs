int n = int.Parse(Console.ReadLine());
char[,] map = new char[n, n];
string[] commands = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);


int squieelRow = -1, squieelCol = -1;

int countColectedNuts = 0; 
for (int i = 0; i < n; i++)
{
    string cols = Console.ReadLine();
    for (global::System.Int32 j = 0; j < n; j++)
    {
        map[i, j] = cols[j];
        if (cols[j] == 's')
        {
            squieelRow = i;
            squieelCol = j;
        }
        
    }
}
bool hasColectedAllNuts = false;
bool hasSteppedOnTrap = false;
bool isOutOfTheMap = false;
for (int i = 0; i < commands.Length; i++)
{
    
 
    switch (commands[i])
    {
        case "up":
            if (squieelRow - 1 >= 0)
            {
                squieelRow--;
            }
            else
            {
                isOutOfTheMap = true;
            }
            break;

        case "down":
            if (squieelRow + 1 < n)
            {
                squieelRow++;
            }
            else
            {
                isOutOfTheMap = true;
            }
            break;

        case "left":
            if (squieelCol - 1 >= 0)
            {
                squieelCol--;
            }
            else
            {
                isOutOfTheMap = true;
            }
            break;

        case "right":
            if (squieelCol + 1 < n)
            {
                squieelCol++;
            }
            else
            {
                isOutOfTheMap = true;
            }
            break;

    }

    if (isOutOfTheMap)
    {
        Console.WriteLine("The squirrel is out of the field.");
        break;
    }


    if (map[squieelRow, squieelCol] == 'h')
    {
        countColectedNuts++;
        map[squieelRow, squieelCol] = '*';
        if (countColectedNuts == 3)
        {
            hasColectedAllNuts = true;
            break; 
        }
    }
    else if (map[squieelRow, squieelCol] == 't')
    {
        hasSteppedOnTrap = true;
        break; 
    }
   



}



if (hasSteppedOnTrap && !isOutOfTheMap)
{
    Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
}
else if (countColectedNuts < 3 && !isOutOfTheMap)
{
    Console.WriteLine("There are more hazelnuts to collect.");
}
else if (hasColectedAllNuts && !isOutOfTheMap)
{
    Console.WriteLine("Good job! You have collected all hazelnuts!");
}


Console.WriteLine($"Hazelnuts collected: {countColectedNuts} ");