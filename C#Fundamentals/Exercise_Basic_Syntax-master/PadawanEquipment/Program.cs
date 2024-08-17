namespace PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int countStud = int.Parse(Console.ReadLine());
            decimal priceLight = decimal.Parse(Console.ReadLine());
            decimal priceRobes = decimal.Parse(Console.ReadLine());
            decimal priceBelts = decimal.Parse(Console.ReadLine());

            decimal totalLight = priceLight * (countStud + (Math.Ceiling(countStud * 0.1m)));
            int freeBelts = countStud / 6;
            decimal totalBelts = priceBelts * (countStud - freeBelts);
            decimal totalRobes = priceRobes * countStud;


            decimal totalPrice = totalLight + totalBelts + totalRobes;


            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                decimal neededMoney = totalPrice - money;
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }





        }
    }
}
