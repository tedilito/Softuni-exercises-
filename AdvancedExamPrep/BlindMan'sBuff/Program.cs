int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
char[,] field = new char[sizes[0], sizes[1]];

int BlindRow = -1, BlindCol = -1;

for (int i = 0; i < sizes[0]; i++)
{
    string[] row = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for (global::System.Int32 j = 0; j < sizes[1]; j++)
    {
        field[i, j] = char.Parse(row[j]);
        if (row[j] == "B")
        {
            BlindRow = i; BlindCol = j;
        }

    }
}

int countTouched = 0;
int countMoves = 0;
bool hasTouchedAllPlayers = false;
string commands;
while ((commands = Console.ReadLine()) != "Finish")
{
    switch (commands)
    {

        case "up":
            if (BlindRow - 1 >= 0)
            {
                if (field[BlindRow - 1,BlindCol] != 'O')
                {
                    BlindRow--;
                }
                else
                {
                    continue;
                }
            }
            else
            {
                continue;
            }
            break;

        case "down":
            if (BlindRow + 1 < field.GetLength(0))
            {
                if (field[BlindRow + 1, BlindCol] != 'O')
                {
                    BlindRow++;
                }
                else
                {
                    continue;   
                }
            }
            else
            {
                continue;
            }
            break;

        case "left":
            if (BlindCol - 1 >= 0)
            {
                if (field[BlindRow, BlindCol - 1] != 'O')
                {
                    BlindCol--;
                }
                else
                {
                    continue;
                }
            }
            else
            {
                continue;
            }
            break;

        case "right":
            if (BlindCol + 1 < field.GetLength(1))
            {
                if (field[BlindRow , BlindCol + 1] != 'O')
                {
                    BlindCol++;
                }
                else
                {
                    continue;
                }
            }
            else
            {
                continue;
            }
            break;
    }
    if (field[BlindRow, BlindCol ] == 'P')
    {
        countTouched++;
        countMoves++;
        field[BlindRow, BlindCol] = '-';
        if (countTouched == 3)
        {
            hasTouchedAllPlayers = true;
            break; 
        }
    }
    else
    {
        countMoves++;
    }

}
Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {countTouched} Moves made: {countMoves}");