namespace RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            decimal priceHead = decimal.Parse(Console.ReadLine());
            decimal priceMouse = decimal.Parse(Console.ReadLine());
            decimal priceKeyboard = decimal.Parse(Console.ReadLine());
            decimal prideDisplay = decimal.Parse(Console.ReadLine());


            int trashedHead = lostGames / 2;
            int trashedMouse = lostGames / 3;
            int trashedKeyboard = lostGames / 6;
            int trashedDisplay = lostGames / 12;



            decimal price = (trashedHead * priceHead) + (trashedMouse * priceMouse) + (priceKeyboard * trashedKeyboard) + (trashedDisplay * prideDisplay);
            Console.WriteLine($"Rage expenses: {price:f2} lv.");





        }
    }
}
