int n = int.Parse(Console.ReadLine());
HashSet<string> chemicals = new HashSet<string>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    for (global::System.Int32 j = 0; j < input.Length; j++)
    {
        chemicals.Add(input[j]);
    }
    
}
Console.WriteLine(string.Join(" ",chemicals.OrderBy(x => x)));