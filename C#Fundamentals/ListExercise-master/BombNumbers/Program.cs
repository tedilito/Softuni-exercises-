namespace BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] bombArguments = Console.ReadLine().Split();
            int bombNumber  = int.Parse(bombArguments[0]);
            int powerOfBomb = int.Parse(bombArguments[1]);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == bombNumber)
                {
                    int leftIndex = Math.Max(i - powerOfBomb, 0);
                    int rightIndex = Math.Min(i + powerOfBomb, list.Count - 1);

                    list.RemoveRange(leftIndex, rightIndex - leftIndex + 1);
                    i = leftIndex - 1; 
                }
            }




        
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum+= list[i];
            }
            Console.WriteLine();
        }
    }
}
