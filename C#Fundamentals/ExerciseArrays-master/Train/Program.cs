namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfWagons = int.Parse(Console.ReadLine());
            int sumOfPeople = 0;
            int[] arr = new int[numOfWagons];
            
                
            for (int i = 0; i < numOfWagons; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }



            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                sumOfPeople += arr[i];

            }
            Console.WriteLine();
            Console.WriteLine(sumOfPeople);
        }
    }
}
