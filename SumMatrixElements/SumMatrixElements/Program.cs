int[] RowsColumnsInput = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
int[,] matrix = new int[RowsColumnsInput[0], RowsColumnsInput[1]];
int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int j = 0; j < matrix.GetLength(1); j++)
	{
        
        matrix[i, j] = numbers[j];
		sum += matrix[i, j];
	}
}
Console.WriteLine(RowsColumnsInput[0]);
Console.WriteLine(RowsColumnsInput[1]);
Console.WriteLine(sum);