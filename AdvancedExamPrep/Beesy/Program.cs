namespace Beesy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[,] field = new string[size, size];
            int energy = 15;
            int collectedNectar = 0;
            int beeRow = 0;
            int beeCol = 0;
            bool isRestored = false;
            bool isHiveReached = false;

            for (int i = 0; i < field.GetLength(0); i++)
            {
                string newRow = Console.ReadLine();
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = newRow[j].ToString();
                    if (field[i, j] == "B")
                    {
                        beeRow = i;
                        beeCol = j;
                        field[i, j] = "-";
                    }
                }
            }

            while (energy > 0 && !isHiveReached)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "up": beeRow = (beeRow - 1 + size) % size; break;
                    case "down": beeRow = (beeRow + 1) % size; break;
                    case "left": beeCol = (beeCol - 1 + size) % size; break;
                    case "right": beeCol = (beeCol + 1) % size; break;
                }
                energy--;

                if (field[beeRow, beeCol] == "-")
                {
                    if (energy == 0 && collectedNectar >= 30 && !isRestored)
                    {
                        energy = collectedNectar - 30;
                        collectedNectar = 30;
                        isRestored = true;
                    }
                    continue;
                }

                if (char.IsDigit(field[beeRow, beeCol][0]))
                {
                    collectedNectar += int.Parse(field[beeRow, beeCol]);
                    field[beeRow, beeCol] = "-";
                }

                if (field[beeRow, beeCol] == "H")
                {
                    isHiveReached = true;
                    break;
                }

                if (energy == 0 && collectedNectar >= 30 && !isRestored)
                {
                    energy = collectedNectar - 30;
                    collectedNectar = 30;
                    isRestored = true;
                }
                else if (energy == 0)
                {
                    break;
                }
            }

            field[beeRow, beeCol] = "B";

            if (energy == 0 && !isHiveReached)
            {
                Console.WriteLine($"This is the end! Beesy ran out of energy.");
            }
            else if (collectedNectar < 30)
            {
                Console.WriteLine($"Beesy did not manage to collect enough nectar.");
            }
            else
            {
                Console.WriteLine($"Great job, Beesy! The hive is full. Energy left: {energy}");
            }

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
