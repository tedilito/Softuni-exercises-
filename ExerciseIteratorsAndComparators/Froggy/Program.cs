namespace Froggy
{
    public class Program
    {
        public static void Main()
        {
            int[] stoneNumbers = Console.ReadLine()
                                    .Split(", ")
                                    .Select(int.Parse)
                                    .ToArray();

         
            Lake lake = new Lake(stoneNumbers);

           
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}