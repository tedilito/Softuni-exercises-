namespace SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            string[] inputArr = input.Split();

            int[] arr = inputArr.Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
