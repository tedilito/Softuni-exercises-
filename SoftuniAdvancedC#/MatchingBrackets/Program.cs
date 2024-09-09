string equation = Console.ReadLine(); 
Stack<int> indexes = new Stack<int>();

for (int i = 0; i < equation.Length; i++)
{
    if (equation[i] == '(')
    {
        indexes.Push(i);
    }
    else if (equation[i] == ')')
    {
        int startIndex = indexes.Pop();
        string subString = string.Empty;
        //for (global::System.Int32 j = startIndex; j <= i ; j++)
        //{
        //    subString += equation[j];
        //}
       subString = equation.Substring(startIndex,i - startIndex + 1);
        Console.WriteLine(subString);
    }
}