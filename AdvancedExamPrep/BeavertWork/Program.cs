int n = int.Parse(Console.ReadLine());
char[,] pond = new char[n, n];
int beavrRow = -1, beavrCol = -1;
int countBranches = 0;
List<char> branches = new List<char>();
for (int i = 0; i < n; i++)
{
    string[] row = Console.ReadLine().Split();
    for (global::System.Int32 j = 0; j < n; j++)
    {
        pond[i, j] = char.Parse(row[j]);
        if (row[j] == "B")
        {
            beavrRow = i;
            beavrCol = j;
        }
        else if (char.IsLower(char.Parse(row[j])))
        {
            countBranches++;
        }
    }
}
int countColleced = 0;
string command;
bool hasColectedAll = false;
while ((command = Console.ReadLine()) != "end")
{
    pond[beavrRow, beavrCol] = '-';
    switch (command)
    {

        case "up":
            if (beavrRow - 1 >= 0)
            {
                beavrRow--;
            }
            else
            {
                if (branches.Any())
                {
                    branches.RemoveAt(branches.Count - 1);
                }
             
            }
            break;

        case "down":
            if (beavrRow + 1 < n)
            {
                beavrRow++;
            }
            else
            {
                if (branches.Any())
                {
                    branches.RemoveAt(branches.Count - 1);
                }
            }
            break;

        case "left":
            if (beavrCol - 1 >= 0)
            {
                beavrCol--;
            }
            else
            {
                if (branches.Any())
                {
                    branches.RemoveAt(branches.Count - 1);
                }
            }
            break;

        case "right":
            if (beavrCol + 1 < n)
            {
                beavrCol++;
            }
            else
            {
                if (branches.Any())
                {
                    branches.RemoveAt(branches.Count - 1);
                }
            }
            break;

        default:
            break;
    }

    if (char.IsLower(pond[beavrRow, beavrCol]))
    {
        branches.Add(pond[beavrRow, beavrCol]);
        pond[beavrRow, beavrCol] = '-';
        countColleced++;
    }
    else if (pond[beavrRow, beavrCol] == 'F')
    {
        pond[beavrRow, beavrCol] = '-';
        switch (command)
        {

            case "up":
                if (beavrRow == 0)
                {
                    beavrRow = n - 1;
                }
                else
                {
                    beavrRow = 0;
                }

                break;

            case "down":
                if (beavrRow == n - 1)
                {
                    beavrRow = 0;
                }
                else
                {
                    beavrRow = n - 1;
                }
                break;

            case "left":
                if (beavrCol == 0)
                {
                    beavrCol = n - 1;
                }
                else
                {
                    beavrCol = 0;
                }
                break;

            case "right":

                if (beavrCol == n - 1)
                {
                    beavrCol = 0;
                }
                else
                {
                    beavrCol = n - 1;
                }

                break;

            default:
                break;
        }
        if (char.IsLower(pond[beavrRow, beavrCol]))
        {
            countColleced++;
            branches.Add(pond[beavrRow, beavrCol]);
            pond[beavrRow, beavrCol] = '-';
        }
    }
    pond[beavrRow, beavrCol] = 'B';
    if (countBranches == countColleced)
    {
        hasColectedAll = true;
        break;
    }

}
if (hasColectedAll)
{
    Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches)}.");
}
else
{
    Console.WriteLine($"The Beaver failed to collect every wood branch. There are {countBranches - countColleced} branches left.");
}

for (int i = 0; i < n; i++)
{
    for (global::System.Int32 j = 0; j < n; j++)
    {
        Console.Write(pond[i,j] + " ");
    }
    Console.WriteLine();
}