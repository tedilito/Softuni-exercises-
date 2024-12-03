namespace MoneyTransaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bankAccounts = Console.ReadLine().Split(",");
            Dictionary<int, decimal> bankAccs = new Dictionary<int, decimal>();
            foreach (string bankAccount in bankAccounts)
            {
                string[] bankAcc = bankAccount.Split("-");
                bankAccs.Add(int.Parse(bankAcc[0]), decimal.Parse(bankAcc[1]));
            }

            string commands;
            while ((commands = Console.ReadLine()) != "End")
            {
                string[] arguments = commands.Split();
                int accNum = int.Parse(arguments[1]);
                decimal sum = decimal.Parse(arguments[2]);
                try
                {
                    if (bankAccs.ContainsKey(accNum))
                    {

                        if (arguments[0] == "Deposit")
                        {
                            bankAccs[accNum] += sum;
                            Console.WriteLine($"Account {accNum} has new balance: {bankAccs[accNum]:F2}");
                        }
                        else if (arguments[0] == "Withdraw")
                        {
                            if (sum <= bankAccs[accNum])
                            {
                                bankAccs[accNum] -= sum;
                                Console.WriteLine($"Account {accNum} has new balance: {bankAccs[accNum]:F2}");
                            }
                            else
                            {
                                throw new ArgumentException("Insufficient balance!");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Invalid command!");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Invalid account!");
                    }

                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
               

            }
        }
    }
}
