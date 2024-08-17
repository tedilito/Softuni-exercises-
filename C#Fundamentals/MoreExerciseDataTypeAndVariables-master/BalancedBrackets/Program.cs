int numOfLines = int.Parse(Console.ReadLine());
int opening = 0;
int closing = 0;
for (int i = 0; i < numOfLines; i++)
{
    string input = Console.ReadLine();

    if (input == ")")
    {
        closing++;
    }
    else if (input == "(")
    {
        opening++;
        if (closing - opening != 0)
        {
            Console.WriteLine("UNBALANCED");
            return;

        }
    }


 


}
if (opening == closing)
{
    Console.WriteLine("BALANCED");
}
else
{
    Console.WriteLine("UNBALANCED");
}



