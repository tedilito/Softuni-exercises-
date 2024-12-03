using System;

int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int n = nums[0];
int m = nums[1];

char[,] neighborhood = new char[n, m];

int boyRow = -1, boyCol = -1;
int StartboyRow = -1, StartboyCol = -1;
for (int i = 0; i < n; i++)
{
    string cols = Console.ReadLine();
    for (global::System.Int32 j = 0; j < m; j++)
    {
        neighborhood[i, j] = cols[j];

        if (cols[j] == 'B')
        {
            boyRow = i;
            StartboyCol = j;
            StartboyRow = i;
            boyCol = j;
        }
    }
}
string commands = Console.ReadLine();
bool hasPassedTheLimits = false;
while (true)
{
    switch (commands)
    {
        case "up":
            if (boyRow - 1 >= 0 && neighborhood[boyRow - 1, boyCol] != '*')
            {
                boyRow--;
            }
            else if (boyRow - 1 < 0)
            {
                isOverTheLimits();
            }
           


            break;

        case "down":

            if (boyRow + 1 < n && neighborhood[boyRow + 1, boyCol] != '*')
            {
                boyRow++;
            }
            else if (boyRow + 1 >= n)
            {
                isOverTheLimits();
            }
           
            break;

        case "left":
            if (boyCol - 1 >= 0 && neighborhood[boyRow, boyCol - 1] != '*')
            {
                boyCol--;
            }
            else if (boyCol - 1 < 0)
            {
                isOverTheLimits();
            }
          


            break;

        case "right":
            if (boyCol + 1 < m && neighborhood[boyRow, boyCol + 1] != '*')
            {
                boyCol++;
                
            }
            else if (boyCol + 1 >= m)
            {
                isOverTheLimits();

            }
          
            break;


    }

    if (hasPassedTheLimits)
    {
        break;
    }
    
    if (neighborhood[boyRow, boyCol] == 'P')
    {
        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
        neighborhood[boyRow, boyCol] = 'R';
    }
    else if (neighborhood[boyRow, boyCol] == '-')
    {
        neighborhood[boyRow, boyCol] = '.';
    }
    else if (neighborhood[boyRow, boyCol] == 'A')
    {
        neighborhood[boyRow, boyCol] = 'P';
        Console.WriteLine("Pizza is delivered on time! Next order...");
        break;
    }


    commands = Console.ReadLine();
}


for (int i = 0; i < n; i++)
{

    for (global::System.Int32 j = 0; j < m; j++)
    {
        Console.Write(neighborhood[i, j]);
    }
    Console.WriteLine();
}



void isOverTheLimits()
{
    Console.WriteLine("The delivery is late. Order is canceled.");
    neighborhood[StartboyRow, StartboyCol] = ' ';
    hasPassedTheLimits = true;  

}