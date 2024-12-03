using System.Diagnostics.CodeAnalysis;

int[] rowsAndColumns = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = rowsAndColumns[0], columns = rowsAndColumns[1];
int[,] matrix = new int[rows, columns];


for (global::System.Int32 j = 0; j < matrix.GetLength(0); j++)
{
    int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int i = 0; i < matrix.GetLength(1); i++)
    {

        matrix[j, i] = nums[i];
    }
}


for (int i = 0; i < matrix.GetLength(1); i++)
{
    int sum = 0;

    for (global::System.Int32 j = 0; j < matrix.GetLength(0); j++)
    {

        sum += matrix[j,i];
    }
    Console.WriteLine(sum);
}
