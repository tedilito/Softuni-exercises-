int n = int.Parse(Console.ReadLine());
char[,] text = new char[n, n];
for (int i = 0; i < text.GetLength(0); i++)
{
    string[] input = Console.ReadLine().Split();

    for (global::System.Int32 j = 0; j < text.GetLength(1); j++)
    {
        string charToInsertIntoMatrix = input[0];
        text[i, j] = charToInsertIntoMatrix[j];
    }
}
char toSearchfor = char.Parse(Console.ReadLine());
bool isFound = false;
for (int i = 0; i < text.GetLength(0); i++)
{
    for (global::System.Int32 j = 0; j < text.GetLength(1); j++)
    {

        if (text[i, j] == toSearchfor)
        {
            Console.WriteLine($"({i}, {j})");
            isFound = true;
        }

    }
}
if (!isFound)
{
    Console.WriteLine($"{toSearchfor} does not occur in the matrix");
}