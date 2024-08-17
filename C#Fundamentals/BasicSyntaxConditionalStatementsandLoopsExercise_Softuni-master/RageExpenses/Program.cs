namespace RageExpenses
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int lostGames = int.Parse(Console.ReadLine());
                decimal headsetPrice = decimal.Parse(Console.ReadLine());
                decimal mousePrice = decimal.Parse(Console.ReadLine());
                decimal keyboardPrice = decimal.Parse(Console.ReadLine());
                decimal displayPrice = decimal.Parse(Console.ReadLine());
                int trashedHeadset = 0;
                int trashedMouse = 0;
                int trashedKeyboard = 0;
                int trashedDisplay = 0;
                int counter = 0;

                trashedHeadset = lostGames / 2;
                trashedMouse = lostGames / 3;
                trashedKeyboard = lostGames / 6;
                trashedDisplay = lostGames / 12;

                decimal rageExpenses = (headsetPrice * trashedHeadset) + (mousePrice * trashedMouse) + (keyboardPrice * trashedKeyboard) + (displayPrice * trashedDisplay);
                Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
            }
        }
    }



   
