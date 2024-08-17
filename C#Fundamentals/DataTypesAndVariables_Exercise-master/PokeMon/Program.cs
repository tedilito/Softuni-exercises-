namespace PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double NHalf = (N * 0.5) ;
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int countTargets = 0; 
            while (N >= M)
            {
                N -= M; 
                countTargets++;
                if (N == NHalf)
                {
                    if (N != 0 && Y != 0)
                    {
                        N /= Y;
                    }
                   
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(countTargets);
        }
    }
}
