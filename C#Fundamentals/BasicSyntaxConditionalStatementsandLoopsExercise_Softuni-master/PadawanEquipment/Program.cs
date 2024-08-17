namespace PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            decimal priceLight = decimal.Parse(Console.ReadLine());
            decimal priceRobes = decimal.Parse(Console.ReadLine());
            decimal priceBelts = decimal.Parse(Console.ReadLine());
            double freeBelts = 0;
            if (countStudents > 6)
            {
                freeBelts =  countStudents / 6;
            }


            decimal priceTotalLight = priceLight * (countStudents + (Math.Ceiling(countStudents * 0.1m)));
            decimal priceTotalRobes = priceRobes * countStudents;
           decimal priceTotalBelts = priceBelts * (countStudents - (decimal)freeBelts);

            decimal total = priceTotalLight + priceTotalRobes + priceTotalBelts;

            if (total <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                decimal neededMoney = total - money;
                Console.WriteLine($" John will need {neededMoney:f2}lv more.");
            }
        }
    }
}
