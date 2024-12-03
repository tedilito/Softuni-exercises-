int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
char[,] map = new char[dimensions[0], dimensions[1]];

int playerRow = -1, playerCol = -1;

for (int i = 0; i < dimensions[0]; i++)
{
    char[] column = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int j = 0; j < dimensions[1]; j++)
    {
        map[i, j] = column[j];
        if (column[j] == 'B')
        {
            playerRow = i;
            playerCol = j;
        }
    }
}

string command;
int countTouchedPlayers = 0;
int countMoves = 0;

while ((command = Console.ReadLine()) != "Finish")
{
 
    int newRow = playerRow;
    int newCol = playerCol;

    switch (command)
    {
        case "up":
            newRow = playerRow - 1;
            break;
        case "down":
            newRow = playerRow + 1;
            break;
        case "left":
            newCol = playerCol - 1;
            break;
        case "right":
            newCol = playerCol + 1;
            break;
    }

    
    if (newRow >= 0 && newRow < dimensions[0] && newCol >= 0 && newCol < dimensions[1] && map[newRow, newCol] != 'O')
    {
       
        playerRow = newRow;
        playerCol = newCol;

        if (map[playerRow, playerCol] == 'P')
        {
            countTouchedPlayers++;
            map[playerRow, playerCol] = '-'; 
        }

    
        countMoves++;

      
        if (countTouchedPlayers == 3)
        {
            break; 
        }
    }
}


Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {countTouchedPlayers} Moves made: {countMoves}");
