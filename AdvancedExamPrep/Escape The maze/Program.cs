using System.Drawing;

int n = int.Parse(Console.ReadLine());
char[,] maze = new char[n, n];
int playerRow = -1, playerCol = -1;

int playerHealth = 100;
bool hasFoundExit = false;
bool hasDiedOfMonster = false;
for (int i = 0; i < maze.GetLength(0); i++)
{
    string row = Console.ReadLine();
    for (int j = 0; j < maze.GetLength(1); j++)
    {
        maze[i, j] = row[j];
        if (row[j] == 'P')
        {
            playerRow = i; playerCol = j;
            maze[i, j] = '-';
        }
    }
}
string commands = Console.ReadLine();
while (playerHealth > 0 && hasFoundExit == false && hasDiedOfMonster == false)
{

    switch (commands)
    {
        case "up":
            if (playerRow - 1 >= 0)
            {
                playerRow -= 1;
            }
            break;

        case "down":
            if (playerRow + 1 <= maze.GetLength(0) - 1)
            {
                playerRow += 1;
            }
            break;

        case "left":
            if (playerCol - 1 >= 0)
            {
                playerCol -= 1;
            }
            break;

        case "right":
            if (playerCol + 1 <= maze.GetLength(1) - 1)
            {
                playerCol += 1;
            }
            break;
    }

    if (maze[playerRow, playerCol] == 'X')
    {
        maze[playerRow, playerCol] = 'P';
        hasFoundExit = true;
        break;
    }
    else if (maze[playerRow, playerCol] == 'M')
    {
        playerHealth -= 40;
        if (playerHealth > 0)
        {
            maze[playerRow, playerCol] = '-' ; 
        }
        else
        {
            maze[playerRow, playerCol] = 'P';
            hasDiedOfMonster = true;

            break;
        }
    }
    else if (maze[playerRow, playerCol] == 'H')
    {
        maze[playerRow, playerCol] = '-';
        if (playerHealth >= 85)
        {
            playerHealth = 100;
        }
        else if (playerHealth < 85)
        {
            playerHealth += 15;
        }
    }

    commands = Console.ReadLine();
}

if (hasDiedOfMonster)
{
    Console.WriteLine("Player is dead. Maze over!");
    playerHealth = 0;
    
}
else if (hasFoundExit)
{
    Console.WriteLine("Player escaped the maze. Danger passed!");
}

Console.WriteLine($"Player's health: {playerHealth} units");


for (int i = 0; i < maze.GetLength(0); i++)
{
   
    for (int j = 0; j < maze.GetLength(1); j++)
    {
        Console.Write(maze[i,j]);
    }
    Console.WriteLine();
}