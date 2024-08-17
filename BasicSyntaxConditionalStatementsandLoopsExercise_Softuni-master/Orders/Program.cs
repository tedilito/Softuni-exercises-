namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double price = 0;
            double total = 0;
            for (int i = 0; i < n; i++)
            {
                double priceCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int countCapsules = int.Parse(Console.ReadLine());
                price = ((days * countCapsules) * priceCapsule);
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                total += price;
            }
            Console.WriteLine($"Total: ${total:f2}");

        }
    }
}
