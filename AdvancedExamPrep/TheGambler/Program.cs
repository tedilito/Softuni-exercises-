int n = int.Parse(Console.ReadLine());

char[,] board = new char[n, n];
int playerRow = -1, playerCol = -1;
for (int i = 0; i < n; i++)
{
    string col = Console.ReadLine();
    for (global::System.Int32 j = 0; j < n; j++)
    {
        board[i, j] = col[j];
        if (col[j] == 'G')
        {
            playerRow = i; playerCol = j;

            board[i, j] = '-';
        }
    }
}

int money = 100;
string commands;
bool hasWonTheJackpot = false;
bool hasLeftBoundries = false;
while ((commands = Console.ReadLine()) != "end" && money > 0)
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
                OutsideBoundaries();
                break;
            }

            break;

        case "down":
            if (playerRow + 1 < board.GetLength(0))
            {
                playerRow++;
            }
            else
            {
                OutsideBoundaries();
                break;
            }
            break;

        case "left":
            if (playerCol - 1 >= 0)
            {
                playerCol--;
            }
            else
            {
                OutsideBoundaries();
                break;
            }
            break;

        case "right":
            if (playerCol + 1 < board.GetLength(1))
            {
                playerCol++;
            }
            else
            {
                OutsideBoundaries();
                break;
            }
            break;
    }

    if (board[playerRow, playerCol] == 'W')
    {
        board[playerRow, playerCol] = '-';
        money += 100;
    }
    else if (board[playerRow, playerCol] == 'P')
    {
        board[playerRow, playerCol] = '-';
        money -= 200;
    }
    else if (board[playerRow, playerCol] == 'J')
    {
        money += 100000;
        board[previousRow, previousCol] = '-';
        board[playerRow, playerCol] = 'G';
        hasWonTheJackpot = true;
        break;
    }
    board[playerRow, playerCol] = 'G';
    board[previousRow, previousCol] = '-';
}

if (hasWonTheJackpot)
{
    Console.WriteLine("You win the Jackpot!");
    Console.WriteLine($"End of the game. Total amount: {money}$");
    PrintMatrix();


}
else if (money > 0)
{
    Console.WriteLine($"End of the game. Total amount: {money}$");
    PrintMatrix();
}
else
{
    OutsideBoundaries();
}

void OutsideBoundaries()
{
    Console.WriteLine("Game over! You lost everything!");
    hasLeftBoundries = true;
}
void PrintMatrix()
{
    for (int i = 0; i < n; i++)
    {

        for (global::System.Int32 j = 0; j < n; j++)
        {
            Console.Write(board[i, j]);
        }
        Console.WriteLine();
    }
}