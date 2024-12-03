int n = int.Parse(Console.ReadLine());
char[,] wall = new char[n, n];

int countHoles = 0;
int countOfRods = 0;
int playerRow = -1, playerCol = -1;
for (int i = 0; i < n; i++)
{
    string rows = Console.ReadLine();
    for (global::System.Int32 j = 0; j < n; j++)
    {
        wall[i, j] = rows[j];
        if (rows[j] == 'V')
        {
            playerRow = i;
            playerCol = j;
            countHoles++;
            wall[i, j] = '*';
        }
    }
}



string commands;
int previousRow = -1, previousCol = -1;
bool hasHitElectricCable = false;
while ((commands = Console.ReadLine()) != "End")
{
    if (playerCol != -1)
    {
        previousRow = playerRow;
        previousCol = playerCol;
    }

    switch (commands)
    {

        case "up":
            if (playerRow - 1 >= 0)
            {
                playerRow--;
            }
            else
            {
                continue;
            }
            break;

        case "down":
            if (playerRow + 1 < wall.GetLength(0))
            {
                playerRow++;
            }
            else
            {
                continue;
            }
            break;

        case "left":
            if (playerCol - 1 >= 0)
            {
                playerCol--;
            }
            else
            {
                continue;
            }
            break;

        case "right":
            if (playerCol + 1 < wall.GetLength(1))
            {
                playerCol++;
            }
            else
            {
                continue;
            }
            break;
    }

    if (wall[playerRow, playerCol] == 'C')
    {
        hasHitElectricCable = true;
        wall[playerRow, playerCol] = 'E';
        countHoles++;
        break; 


    }
    else if (wall[playerRow, playerCol] == 'R')
    {
        playerRow = previousRow;
        playerCol = previousCol;
        countOfRods++;

        Console.WriteLine("Vanko hit a rod!");
    }
    else if (wall[playerRow, playerCol] == '*')
    {
        Console.WriteLine($"The wall is already destroyed at position [{playerRow}, {playerCol}]!");
    }
    else
    {
        wall[playerRow, playerCol] = '*';
        countHoles++;
    }

   

}


if (hasHitElectricCable)
{
    Console.WriteLine($"Vanko got electrocuted, but he managed to make {countHoles} hole(s).");
}
else
{
    Console.WriteLine($"Vanko managed to make {countHoles} hole(s) and he hit only {countOfRods} rod(s).");
    wall[playerRow, playerCol] = 'V';
}


for (int i = 0; i < n; i++)
{
    
    for (global::System.Int32 j = 0; j < n; j++)
    {
        Console.Write(wall[i,j]);
    }
    Console.WriteLine();
}
