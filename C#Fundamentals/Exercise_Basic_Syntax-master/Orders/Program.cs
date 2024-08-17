namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int count = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            for (int i = 1; i <= count; i++)
            {
                decimal priceCapsule = decimal.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int countCapsule = int.Parse(Console.ReadLine());

                decimal price = ((days * countCapsule) * priceCapsule);
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totalPrice += price;

            }

            Console.WriteLine($"Total: ${totalPrice:f2}");

        }
    }
}
