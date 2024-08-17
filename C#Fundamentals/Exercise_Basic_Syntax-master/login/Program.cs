namespace login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string realPass = string.Empty;
            int counter = 0;
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                realPass += userName[i];
            }
            bool isPassword = false;

            while (!isPassword)
            {

                string pass = Console.ReadLine();
                counter++;
                if (pass == realPass)
                {
                    isPassword = true;
                    Console.WriteLine($"User {userName} logged in.");
                }
                else if (counter >= 4 && isPassword == false)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

              
                    


            }

        }
    }
}
