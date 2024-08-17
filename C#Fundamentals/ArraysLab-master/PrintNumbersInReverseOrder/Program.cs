namespace PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }





            for (int i = 0; i < arr.Length; i++) // or reverse for 
            {
                Console.Write(arr[arr.Length - 1 - i] + " ");
            }







        }
    }
}
