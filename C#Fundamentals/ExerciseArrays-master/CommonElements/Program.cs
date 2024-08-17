namespace CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split();
            string[] seconArr = Console.ReadLine().Split();

            for (int i = 0; i < seconArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (seconArr[i] == firstArr[j])
                    {
                        Console.Write(seconArr[i] + " ");
                    }
                }
            }









        }
    }
}
