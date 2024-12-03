using System.Globalization;

int[] dimensions = Console.ReadLine()
    .Split(", ")
    .Select(x => int.Parse(x))
    .ToArray();


int row = dimensions[0];
int col = dimensions[1];
int counterRow = -1, counterCol = -1;
char[,] map = new char[row, col];
for (int i = 0; i < row; i++)
{
    string rowInput = Console.ReadLine();
    for (global::System.Int32 j = 0; j < col; j++)
    {
        map[i, j] = rowInput[j];

        if (rowInput[j] == 'C')
        {
            counterRow = i;
            counterCol = j;
        }

    }
}

int time = 16;
bool hasStartedToDefuse = false;
bool hasFinishedToDefuse = false;
bool hasRunOutOfTime = false;
bool hasBeenKilled = false;
string command = Console.ReadLine();
while (time >= 0)
{
    switch (command)
    {
        case "up":

            if (counterRow - 1 >= 0)
            {
                counterRow--;

            }
            time--;
            break;

        case "down":
            if (counterRow + 1 < map.GetLength(0))
            {
                counterRow++;

            }
            time--;
            break;

        case "left":
            if (counterCol - 1 >= 0)
            {
                counterCol--;

            }
            time--;
            break;

        case "right":
            if (counterCol + 1 < map.GetLength(1))
            {
                counterCol++;

            }
            time--;
            break;

        case "defuse":
            if (map[counterRow, counterCol] == 'B')
            {
                hasStartedToDefuse = true;
                time -= 4;
                if (time >= 0)
                {
                    map[counterRow, counterCol] = 'D';
                    hasFinishedToDefuse = true;
                    break; 
                }
                else
                {
                    map[counterRow, counterCol] = 'X';
                    hasRunOutOfTime = true;
                    break;
                }
            }
            else
            {
                time -= 2;
            }
            break;
    }
    if (map[counterRow, counterCol] == 'T')
    {
        map[counterRow, counterCol] = '*';
        hasBeenKilled = true;
        break;
    }

    if (hasFinishedToDefuse || hasRunOutOfTime)
    {
        break; 
    }

    if (time == 0)
    {
        hasRunOutOfTime = true;
        break;
    }

    command = Console.ReadLine();
}

if (time <= 0 && !hasFinishedToDefuse && !hasStartedToDefuse || hasRunOutOfTime && hasStartedToDefuse )
{
    Console.WriteLine("Terrorists win!");
    Console.WriteLine("Bomb was not defused successfully!");
    Console.WriteLine($"Time needed: {Math.Abs(time)} second/s.");
}
else if (hasFinishedToDefuse)
{
    Console.WriteLine($"Counter-terrorist wins!");
    Console.WriteLine($"Bomb has been defused: {time} second/s remaining.");
}
else if (hasBeenKilled)
{
    Console.WriteLine("Terrorists win!");
}

for (int i = 0; i < row; i++)
{
  
    for (global::System.Int32 j = 0; j < col; j++)
    {
        Console.Write(map[i,j]);

    }
    Console.WriteLine();
}