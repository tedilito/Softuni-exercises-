
int[] rowsCols = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
int n = rowsCols[0];
int m = rowsCols[1];

char[,] map = new char[n, m];
int countCheese = 0;
int mouseRow = -1, mouseCol = -1;
for (int i = 0; i < n; i++)
{
    string column = Console.ReadLine();
    for (global::System.Int32 j = 0; j < m; j++)
    {
        map[i, j] = column[j];
        if (column[j] == 'M')
        {
            mouseRow = i;
            mouseCol = j;
            map[i, j] = '*';
        }
        else if (column[j] == 'C')
        {
            countCheese++;
        }
    }
}
string commands;
while ((commands = Console.ReadLine()) != "danger")
{
    bool isLeftBoundires = false;

    int lastKnownRow = mouseRow;
    int lastKnownCol = mouseCol;

    switch (commands)
    {

        case "up":
            if (mouseRow - 1 >= 0  )
            {
                if (map[mouseRow - 1, mouseCol] != '@')
                {
                    mouseRow--;
                }
               
            }
            else
            {
                Console.WriteLine("No more cheese for tonight!");
                isLeftBoundires = true;
            }
            break;

        case "down":
            if (mouseRow + 1 < n  )
            {
                if (map[mouseRow + 1, mouseCol] != '@')
                {
                    mouseRow++;
                }
               
            }
            else
            {
                Console.WriteLine("No more cheese for tonight!");
                isLeftBoundires = true;

            }
            break;

        case "right":
            if (mouseCol + 1 < m  )
            {
                if (map[mouseRow, mouseCol + 1] != '@')
                {
                    mouseCol++;
                }
               
            }
            else
            {
                Console.WriteLine("No more cheese for tonight!");
                isLeftBoundires = true;
            }
            break;

        case "left":
            if (mouseCol - 1 >= 0 )
            {
                if (map[mouseRow , mouseCol - 1] != '@')
                {
                    mouseCol--;
                }
               
            }
            else
            {
                Console.WriteLine("No more cheese for tonight!");
                isLeftBoundires = true;
            }
            break;
    }


    if (isLeftBoundires)
    {
        map[lastKnownRow, lastKnownCol] = 'M';
        break; 
    }

    if (map[mouseRow, mouseCol] == 'C')
    {
        countCheese--;
        if (countCheese == 0)
        {
            map[mouseRow, mouseCol] = 'M';
            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
            break; 
        }
        else
        {
            map[mouseRow, mouseCol] = '*';
        }
    }
    else if (map[mouseRow, mouseCol] == 'T')
    {
        Console.WriteLine("Mouse is trapped!");
        map[mouseRow, mouseCol] = 'M';
        break; 

    }
   

}
if (commands == "danger")
{
    map[mouseRow, mouseCol] = 'M';
    Console.WriteLine("Mouse will come back later!");
}

for (int i = 0; i < n; i++)
{
    
    for (global::System.Int32 j = 0; j < m; j++)
    {
        Console.Write(map[i,j]);
    }
    Console.WriteLine();
}