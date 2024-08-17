namespace MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            int bestCouner = 0;
            int mostRepeatedNum = 0;
     

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                    if (counter > bestCouner)
                    {
                        bestCouner = counter;
                        mostRepeatedNum = arr[i];
                    }
                }
                else
                {
                    counter = 0;
                }

               

            }

            for (int i = 0; i <= bestCouner; i++)
            {
                Console.Write(mostRepeatedNum + " ");
            }


        }
    }
}
