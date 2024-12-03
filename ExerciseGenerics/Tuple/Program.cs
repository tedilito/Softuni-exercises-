namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string firstName = firstData[0], lastName = firstData[1], address = firstData[2], town = firstData[3] ;
            if (firstData.Length >= 5)
            {
                for (int i = 4; i < firstData.Length; i++)
                {
                    town += " " + firstData[i];
                }
            }

            Threeuple<string, string, string> firstTuple = new Threeuple<string, string, string>($"{firstName} {lastName}",
            address, town);

            string[] secondData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string name = secondData[0], drunkOrNot = secondData[2];
            int litersOfBeer = int.Parse(secondData[1]);
            if (drunkOrNot == "drunk")
            {
                drunkOrNot = "True";
            }
            else
            {
                drunkOrNot = "False";
            }
            Threeuple<string, int, string> secondTuple = new Threeuple<string, int,string>(name, litersOfBeer, drunkOrNot);

            string[] thirdData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
         string nameOfBankAcc = thirdData[0], bankName = thirdData[2];
            double balance = double.Parse(thirdData[1]);

            Threeuple<string, double, string> thirdTuple = new Threeuple<string, double, string>(nameOfBankAcc,balance,bankName);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
