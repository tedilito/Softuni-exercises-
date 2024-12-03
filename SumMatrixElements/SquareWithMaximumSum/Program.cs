int[] rowsAndColumns = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = rowsAndColumns[0], columns = rowsAndColumns[1];
int[,] matrix = new int[rows, columns];

for (global::System.Int32 j = 0; j < matrix.GetLength(0); j++)
{
    int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int i = 0; i < matrix.GetLength(1); i++)
    {

        matrix[j, i] = nums[i];
    }
}


int maxSum = int.MinValue, firstNum = -1, secondNum = -1, thirdNum = -1, fourthNum = -1;
for (int i = 0; i < matrix.GetLength(0) - 1; i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            firstNum = matrix[i, j];
            secondNum = matrix[i, j + 1];
            thirdNum = matrix[i + 1, j];
            fourthNum = matrix[i + 1, j + 1];
        }
    }
}
Console.WriteLine($"{firstNum} {secondNum}");
Console.WriteLine($"{thirdNum} {fourthNum}");
Console.WriteLine(maxSum);