namespace Ecercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            int numOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfLines; i++)
            {
                string input = Console.ReadLine();
                string[] nums = input.Split(' ');


                long leftNum = long.Parse(nums[0]);
                long RightNum = long.Parse(nums[1]);

                long biggerNum = RightNum;
                if (leftNum > RightNum)
                {
                    biggerNum = leftNum;
                }

                long sumOfDigits = 0;

                while (biggerNum != 0)
                {
                    sumOfDigits += biggerNum % 10;
                    biggerNum /= 10;
                }

                Console.WriteLine(Math.Abs(sumOfDigits));

            }






        }
    }
}
