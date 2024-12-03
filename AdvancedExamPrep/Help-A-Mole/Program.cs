internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char[,] map = new char[n, n];

        int molRow = -1, molCol = -1;
        int s1Row = -1, s2Row = -1;
        int s1Col = -1, s2Col = -1;

        bool hasFoundFirstS = false;
        for (int i = 0; i < n; i++)
        {
            string row = Console.ReadLine();
            for (int j = 0; j < n; j++)
            {
                map[i, j] = row[j];

                if (row[j] == 'M')
                {
                    molRow = i;
                    molCol = j;
                }
                else if (row[j] == 'S' && !hasFoundFirstS)
                {
                    s1Row = i;
                    s1Col = j;
                    hasFoundFirstS = true;
                }
                else if (row[j] == 'S')
                {
                    s2Row = i;
                    s2Col = j;
                }
            }
        }


        string commands;
        int totalCountPoints = 0;
        bool hasColectedNeededPoints = false;
        while ((commands = Console.ReadLine()) != "End")
        {
            if (molCol != -1)
            {
                map[molRow, molCol] = '-';
            }
            switch (commands)
            {

                case "up":
                    if (molRow - 1 >= 0)
                    {
                        molRow--;
                    }
                    else
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }
                    break;

                case "down":
                    if (molRow + 1 < map.GetLength(0))
                    {
                        molRow++;
                    }
                    else
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }
                    break;

                case "left":
                    if (molCol - 1 >= 0)
                    {
                        molCol--;
                    }
                    else
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }
                    break;

                case "right":
                    if (molCol + 1 < map.GetLength(1))
                    {
                        molCol++;
                    }
                    else
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }
                    break;
            }

            if (char.IsDigit(map[molRow, molCol]))
            {
                totalCountPoints += int.Parse(map[molRow, molCol].ToString());
                map[molRow, molCol] = '-';
                if (totalCountPoints >= 25)
                {
                    map[molRow, molCol] = 'M';
                    hasColectedNeededPoints = true;
                    break;
                }
            }
            else if (map[molRow, molCol] == 'S')
            {
                map[molRow, molCol] = '-';
                totalCountPoints -= 3;
                if (molRow == s1Row && molCol == s1Col)
                {
                    molRow = s2Row;
                    molCol = s2Col;
                }
                else
                {
                    molRow = s1Row;
                    molCol = s1Col;
                }
            }


            map[molRow, molCol] = 'M';
        }

        if (hasColectedNeededPoints)
        {
            Console.WriteLine("Yay! The Mole survived another game!");
        }
        else
        {
            Console.WriteLine("Too bad! The Mole lost this battle!");
        }

        if (hasColectedNeededPoints)
        {
            Console.WriteLine($"The Mole managed to survive with a total of {totalCountPoints} points.");
        }
        else
        {
            Console.WriteLine($"The Mole lost the game with a total of {totalCountPoints} points.");
        }

        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j < n; j++)
            {
                Console.Write(map[i, j]);
            }
            Console.WriteLine();
        }
    }
}