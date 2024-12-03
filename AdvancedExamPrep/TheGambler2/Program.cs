int n = int.Parse(Console.ReadLine());
char[,] board = new char[n, n];

int gamblerRow = -1, gamblerCol = -1;

for (int i = 0; i < n; i++)
{
    string row = Console.ReadLine();
    for (global::System.Int32 j = 0; j < n; j++)
    {
        board[i, j] = row[j];
        if (board[i, j] == 'G')
        {
            gamblerRow = i;
            gamblerCol = j;
        }
    }
}
int amount = 100; 
string command; 
bool hasLost = false;
bool hasWonJackpot = false;
while ((command = Console.ReadLine()) != "end")
{
    board[gamblerRow, gamblerCol] = '-';
    switch (command)
    {
        case "up":
            if (gamblerRow - 1 >= 0)
            {
                gamblerRow--;
            }
            else
            {
                hasLost = true;
            }
            break;

        case "down":
            if (gamblerRow + 1 < n)
            {
                gamblerRow++;
            }
            else
            {
                hasLost = true;
            }
            break;

        case "left":
            if (gamblerCol - 1 >= 0)
            {
                gamblerCol--;
            }
            else
            {
                hasLost = true;
            }
            break;

        case "right":
            if (gamblerCol + 1 < n)
            {
                gamblerCol++;
            }
            else
            {
                hasLost = true;

            }
            break;

    }
    if (hasLost)
    {
        Console.WriteLine("Game over! You lost everything!");
        break; 
    }
    else if (board[gamblerRow, gamblerCol] == 'P')
    {
        amount -= 200;
        if (amount <= 0)
        {
            Console.WriteLine("Game over! You lost everything!");
            break; 
        }
    }
    else if (board[gamblerRow, gamblerCol] == 'W')
    {
        amount += 100;
    }
    else if (board[gamblerRow, gamblerCol] == 'J')
    {
        hasWonJackpot = true;
        amount += 100000;
        board[gamblerRow, gamblerCol] = 'G';
        break; 
    }
    board[gamblerRow, gamblerCol] = 'G';
}
if (hasWonJackpot)
{
    Console.WriteLine("You win the Jackpot!");
    Console.WriteLine($"End of the game. Total amount: {amount}$");
}
else if (amount > 0)
{
    Console.WriteLine($"End of the game. Total amount: {amount}$");
}

if (amount > 0)
{
    for (int i = 0; i < n; i++)
    {
        
        for (global::System.Int32 j = 0; j < n; j++)
        {
            Console.Write(board[i,j]);
        }
        Console.WriteLine();
    }
}