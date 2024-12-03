using System.Globalization;

int n = int.Parse(Console.ReadLine());
char[,] forest = new char[n,n];
for (int i = 0; i < n; i++)
{
    string[] row = Console.ReadLine().Split();
    for (global::System.Int32 j = 0; j < n; j++)
    {
        forest[i,j] = char.Parse(row[j]);
    }
}
int countBlack = 0, countSummer = 0, countWhite = 0, countBearEaten = 0;

string command;
while ((command = Console.ReadLine()) != "Stop the hunt")
{
    string[] typeOfCommand = command.Split();

    switch (typeOfCommand[0])
    {
        case "Collect":
            int row = int.Parse(typeOfCommand[1]);
            int col = int.Parse(typeOfCommand[2]);
            if (row >= 0 && row < n && col >= 0 && col < n)
            {
                if (forest[row, col] == 'B')
                {
                    countBlack++;
                    forest[row, col] = '-';
                }
                else if (forest[row, col] == 'S')
                {
                    countSummer++;
                    forest[row, col] = '-'; 
                }
                else if (forest[row, col] == 'W')
                {
                    countWhite++;
                    forest[row, col] = '-';
                }
            }
            break;

        case "Wild_Boar":
             row = int.Parse(typeOfCommand[1]);
            col = int.Parse(typeOfCommand[2]);
           string direction = typeOfCommand[3];

           
                switch (direction)
                {

                    case "up":
                    for (int i = row; i >= 0; i-=2)
                    {
                        if (forest[i, col] == 'B' || forest[i, col] == 'S' || forest[i, col] == 'W')
                        {
                            countBearEaten++;
                            forest[i, col] = '-';
                        }
                    }
                    break;

                    case "down":
                    for (int i = row; i < n; i += 2)
                    {
                        if (forest[i, col] == 'B' || forest[i, col] == 'S' || forest[i, col] == 'W')
                        {
                            countBearEaten++;
                            forest[i, col] = '-';
                        }
                    }
                    break;

                    case "left":
                    for (int i = col; i >= 0; i -= 2)
                    {
                        if (forest[row, i] == 'B' || forest[row, i] == 'S' || forest[row, i] == 'W')
                        {
                            countBearEaten++;
                            forest[row, i] = '-';
                        }
                    }
                    break;

                    case "right":
                    for (int i = col; i < n; i += 2)
                    {
                        if (forest[row, i] == 'B' || forest[row, i] == 'S' || forest[row, i] == 'W')
                        {
                            countBearEaten++;
                            forest[row, i] = '-';
                        }
                    }
                    break;
                }


            

            break;

    }
}
Console.WriteLine($"Peter manages to harvest {countBlack} black, {countSummer} summer, and {countWhite} white truffles.");
Console.WriteLine($"The wild boar has eaten {countBearEaten} truffles.");
for (int i = 0; i < n; i++)
{
  
    for (global::System.Int32 j = 0; j < n; j++)
    {
        Console.Write(forest[i,j] + " ");
    }
    Console.WriteLine();
}