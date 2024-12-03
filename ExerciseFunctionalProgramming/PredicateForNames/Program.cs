int lenght = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split();
Predicate<string> isValidName = n => n.Length <= lenght;

for (int i = 0; i < names.Length; i++)
{
    if (isValidName(names[i]))
    {
        Console.WriteLine(names[i]);
    }
}