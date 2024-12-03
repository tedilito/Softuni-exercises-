using System.Runtime.InteropServices;

int n = int.Parse(Console.ReadLine());
char[,] fishingArea = new char[n, n];
int playerRow = -1, playerCol = -1;
for (int i = 0; i < n; i++)
{
    string col = Console.ReadLine();
    for (global::System.Int32 j = 0; j < n; j++)
    {
        fishingArea[i, j] = col[j];
        if (col[j] == 'S')
        {
            playerRow = i;
            playerCol = j;
        }
    }
}
int collectedFish = 0;
string commands;
bool hasFallentIntoW = false;
while ((commands = Console.ReadLine()) != "collect the nets")
{
    int previousRow = playerRow;
    int previousCol = playerCol;
    switch (commands)
    {

        case "up":
            if (playerRow - 1 >= 0)
            {
                playerRow--;
            }
            else
            {
                playerRow = n - 1;
            }

            break;

        case "down":
            if (playerRow + 1 < n)
            {
                playerRow++;
            }
            else
            {
                playerRow = 0;
            }
            break;

        case "left":
            if (playerCol - 1 >= 0)
            {
                playerCol--;
            }
            else
            {
                playerCol = n - 1;
            }
            break;

        case "right":
            if (playerCol + 1 < n)
            {
                playerCol++;
            }
            else
            {
                playerCol = 0;
            }
            break;
    }
    if (Char.IsDigit(fishingArea[playerRow, playerCol]))
    {
        collectedFish += int.Parse(fishingArea[playerRow, playerCol].ToString());
        fishingArea[playerRow, playerCol] = '-';
    }
    else if (fishingArea[playerRow, playerCol] == 'W')
    {
        collectedFish = 0;
        fishingArea[playerRow, playerCol] = 'S';
        hasFallentIntoW = true;
        break;
    }
    fishingArea[playerRow, playerCol] = 'S';
    fishingArea[previousRow, previousCol] = '-';


}
if (hasFallentIntoW)
{
    Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{playerRow},{playerCol}]");
}
else if (collectedFish >= 20)
{
    Console.WriteLine("Success! You managed to reach the quota!");
}
else
{
    Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - collectedFish} tons of fish more.");
}

if (collectedFish > 0)
{
    Console.WriteLine($"Amount of fish caught: {collectedFish} tons.");
}

if (!hasFallentIntoW)
{
    for (int i = 0; i < n; i++)
    {
        
        for (global::System.Int32 j = 0; j < n; j++)
        {
            Console.Write(fishingArea[i,j]);
        }
        Console.WriteLine();
    }
}