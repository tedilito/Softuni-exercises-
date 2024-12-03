int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];
int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (global::System.Int32 j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = nums[j];
    }
}


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (global::System.Int32 j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];


        i++;

    }
    Console.WriteLine(sum);
}