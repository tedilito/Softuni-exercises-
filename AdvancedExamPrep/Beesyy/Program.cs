

int n = int.Parse(Console.ReadLine());
char[,] field = new char[n,n];

int beeRow = -1, beeCol = -1;
for (int i = 0; i < n; i++)
{
    string row = Console.ReadLine();
    for (global::System.Int32 j = 0; j < n; j++)
    {
        field[i, j] = row[j];
        if (row[j] == 'B')
        {
            beeRow = i; 
            beeCol = j;
            field[i, j] = '-';

        }
    }
}


int energy = 15;
int colectedHoney = 0;
int countRecharged = 0;
bool hasReachedHive = false;
bool hasDied = false;
string command = Console.ReadLine();
while (true)
{

    switch (command)
    {

        case "up":
            if (beeRow - 1 >= 0)
            {
                beeRow--;
            }
            else
            {
                beeRow = n - 1; 
            }
            break;

        case "down":
            if (beeRow + 1 < n)
            {
                beeRow++;
            }
            else
            {
                beeRow = 0;
            }
            break;

        case "left":
            if (beeCol - 1 >= 0)
            {
                beeCol--;
            }
            else
            {
                beeCol = n - 1;
            }
            break;

        case "right":
            if (beeCol + 1 < n)
            {
                beeCol++;
            }
            else
            {
                beeCol = 0;
            }
            break;
    }
  
    if (char.IsDigit(field[beeRow, beeCol]))
    {
        colectedHoney += int.Parse(field[beeRow, beeCol].ToString());
        field[beeRow, beeCol] = '-';
        energy--;


    }
    else if (field[beeRow, beeCol] == 'H')
    {
      
        hasReachedHive = true;
        field[beeRow, beeCol] = 'B';
        energy--;
        break; 
    }
    else if (field[beeRow, beeCol] == '-')
    {
        energy--;
    }

    if (energy == 0 && colectedHoney >= 30 && countRecharged == 0)
    {
        energy = colectedHoney - 30;
        colectedHoney = 30; 
        countRecharged++;
    }
    else if (energy == 0)
    {
        hasDied = true;
        field[beeRow, beeCol] = 'B';
        break;
    }


    command = Console.ReadLine();



}
if (hasReachedHive && colectedHoney >= 30)
{
    Console.WriteLine($"Great job, Beesy! The hive is full. Energy left: {energy}");
}
else if (hasReachedHive && colectedHoney < 30)
{
    Console.WriteLine("Beesy did not manage to collect enough nectar.");
}
else if (hasDied)
{
    Console.WriteLine("This is the end! Beesy ran out of energy.");
}
for (int i = 0; i < n; i++)
{
    
    for (global::System.Int32 j = 0; j < n; j++)
    {
        Console.Write(field[i,j]);
    }
    Console.WriteLine();
}