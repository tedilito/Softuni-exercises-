namespace EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isEqual = false;


            for (int i = 0; i < arr.Length; i++)
            {
                int rightSum = 0;
                int leftSum = 0;

                for (int j = i - (1); j >= 0 ; j--)
                {
                    rightSum += arr[j];
                }

                for ( int k =  i + 1; k < arr.Length; k++)
                {
                    leftSum += arr[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                }







            }

            if (!isEqual)
            {
                Console.WriteLine("no");
            }

        }
    }
}
