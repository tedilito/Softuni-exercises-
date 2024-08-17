double num = double.Parse(Console.ReadLine()); 

while (num == -num)
{
    num = double.Parse(Console.ReadLine());
}

if (num != -num)
{
    num = num / 2;
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Negative number! ");
}