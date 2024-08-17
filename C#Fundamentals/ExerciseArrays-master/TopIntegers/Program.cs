namespace TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int l = 0;
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {


                for (int j = i + 1; j <= arr.Length - 1; j++)
                {


                    if (arr[i] > arr[j] )
                    {
                        if (j == arr.Length - 1 )
                        {
                            Console.Write(arr[i] + " ");
                        }
                    }
                    else
                    {
                        break;
                    }

                    




                }






            }


            Console.Write(arr[arr.Length - 1]);


        }



    }
}

