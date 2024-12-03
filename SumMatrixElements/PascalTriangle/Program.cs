int n = int.Parse(Console.ReadLine());
long[][] triangle = new long[n][];
for (int i = 0; i < triangle.Length; i++)
{
    triangle[i] = new long[i+1];
    triangle[i][0] = 1;
    triangle[i][triangle[i].Length-1] = 1;
}


for (int i = 2; i < triangle.Length; i++)
{

    for (global::System.Int32 j = 1; j < triangle[i].Length - 1; j++)
    {
        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
    }
    

}
foreach (long[] row in triangle)
{
    Console.WriteLine(string.Join(" ", row));
}