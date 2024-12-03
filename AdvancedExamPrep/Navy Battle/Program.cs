int n = int.Parse(Console.ReadLine());
char[,] field = new char[n,n];


int playerRow = -1, playerCol = -1; 


for (int i = 0; i < n; i++)
{
    string row = Console.ReadLine();
    for (global::System.Int32 j = 0; j < n; j++)
    {
        field[i, j] = row[j];
        if (row[j] == 'S')
        {
            playerRow = i; playerCol = j;
            field[playerRow, playerCol] = '-';
        }
    }
}

int countMinesRunnedBy = 0;
int countDestroyedShips = 0;

while (true)
{
    string commands = Console.ReadLine();

    switch (commands)
    {
        case "up":
            playerRow--;
            break;

        case "down":
            playerRow++;
            break;

        case "left":
            playerCol--;
            break;

        case "right":
            playerCol++;
            break;
    }
    if (field[playerRow, playerCol] == '*')
    {
        countMinesRunnedBy++;
        field[playerRow, playerCol] = '-';
        if (countMinesRunnedBy == 3)
        {
         
            field[playerRow, playerCol] = 'S';
            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{playerRow}, {playerCol}]!");
            break; 

        }
    }
    else if (field[playerRow, playerCol] == 'C')
    {
        field[playerRow, playerCol] = '-';
        countDestroyedShips++;
        if (countDestroyedShips == 3)
        {
            field[playerRow, playerCol] = 'S';
            Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
            break; 
        }

    }





}
for (int i = 0; i < n; i++)
{

    for (global::System.Int32 j = 0; j < n; j++)
    {
        Console.Write(field[i,j]);
    }
    Console.WriteLine();
}
