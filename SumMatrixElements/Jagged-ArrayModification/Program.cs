using System;

int n = int.Parse(Console.ReadLine());
int[][] jagged = new int[n][];
for (int i = 0; i < n; i++)
{
    jagged[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
}

string input; 
while ((input = Console.ReadLine()) != "END")
{
    string[] commands = input.Split();
    int row = int.Parse(commands[1]);
    int col = int.Parse(commands[2]);
    int value = int.Parse(commands[3]);
    if ( row < 0 || row >= jagged.Length || col < 0 || col >= jagged[row].Length)
    {
        Console.WriteLine("Invalid coordinates");
    }
    else if (commands[0] == "Subtract")
    {
        jagged[row][col] -= value;
    }
    else if (commands[0] == "Add")
    {
        jagged[row][col] += value;
    }
}

foreach (int[] row in jagged)
{
    Console.WriteLine(string.Join(" ", row));
}