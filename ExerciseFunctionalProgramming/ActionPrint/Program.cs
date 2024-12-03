string[] names = Console.ReadLine().Split();

Action<string> actionPrint = x =>  Console.WriteLine(x);

for (int i = 0; i < names.Length; i++)
{
    actionPrint(names[i]);
}