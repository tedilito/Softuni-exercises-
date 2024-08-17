
namespace NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            MakeMatrix(n);
        }

        private static void MakeMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }

}