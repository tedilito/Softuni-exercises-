
string[] names = Console.ReadLine().Split(); 
Action<string> actionPrintSir = x => Console.WriteLine($"Sir {x}");


for (int i = 0; i < names.Length; i++)
{
    actionPrintSir(names[i]);
}