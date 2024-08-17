namespace EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] SecondArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int countIndexChecked = 0;
            int sum = 0;

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] == SecondArr[i])
                {
                    countIndexChecked++;
                    sum += firstArr[i];
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }

            if (countIndexChecked == firstArr.Length)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

        }
    }
}
