namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int pouredCapacity = 0;
           
            for (int i = 0; i < n; i++)
            {
               
                int pourWater = int.Parse(Console.ReadLine());
                
                    pouredCapacity += pourWater;
                if (pouredCapacity > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    pouredCapacity -= pourWater;
                    continue;
                }
                
         
            }
            Console.WriteLine(pouredCapacity);
        }
    }
}
