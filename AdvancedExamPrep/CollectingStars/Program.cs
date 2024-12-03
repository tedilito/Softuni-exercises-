int n = int.Parse(Console.ReadLine());
char[,] map = new char[n, n];
int playerCol = -1, playerRow = -1;
for (int row = 0; row < map.GetLength(0); row++)
{
    char[] rowEntry = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int col = 0; col < map.GetLength(0); col++)
    {
        map[row, col] = rowEntry[col];
        if (rowEntry[col] == 'P')
        {
            playerRow = row;
            playerCol = col;
        }
    }
}

int countStars = 2;
string commands = Console.ReadLine();
map[playerRow, playerCol] = '.';
while (countStars != 10 && countStars > 0)
{
    int previousRow = playerRow, previousCol = playerCol;
    switch (commands)
    {

        case "up":
            if (playerRow - 1 < 0)
            {
                playerCol = 0; 
                playerRow = 0;
            }
            else
            {
                playerRow -= 1;
            }

            break;

        case "down":
            if (playerRow + 1 >= map.GetLength(0))
            {
                playerCol = 0;
                playerRow = 0;
            }
            else
            {
                playerRow += 1;
            }
            break;

        case "left":
            if (playerCol - 1 < 0 )
            {

                playerCol = 0;
                playerRow = 0;
            }
            else
            {
                playerCol -= 1;
            }
            break;

        case "right":
            if (playerCol + 1 >= map.GetLength(1))
            {

                playerCol = 0;
                playerRow = 0;
            }
            else
            {
                playerCol += 1;
            }
            break;
    }

    if (map[playerRow, playerCol] == '*')
    {
        countStars++;
        map[playerRow, playerCol] = '.';
    }
    else if (map[playerRow, playerCol] == '#')
    {
        countStars--;
        playerCol = previousCol;
        playerRow = previousRow;

    }

    commands = Console.ReadLine();


}


if (countStars == 10)
{
    Console.WriteLine("You won! You have collected 10 stars.");
}
else
{
    Console.WriteLine("Game over! You are out of any stars.");
}

Console.WriteLine($"Your final position is [{playerRow}, {playerCol}]");
map[playerRow, playerCol] = 'P';

for (int i = 0; i < map.GetLength(0); i++)
{
    for (int j = 0; j < map.GetLength(1); j++)
    {
        Console.Write(map[i,j] + " ");
    }
    Console.WriteLine();
}
