namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numOfRotation = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfRotation; i++)
            {

                int firstNum = arr[0];
                arr[0] = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j + 1 <= arr.Length -1)
                    {
                        arr[j] = arr[j + 1];
                    }
                   
                }
                
                arr[arr.Length - 1] = firstNum;







            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}
