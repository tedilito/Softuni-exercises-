namespace login
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string userInput = Console.ReadLine();
            bool isRealUser = false;
            string passws = string.Empty;
          ;
            for (int l = userInput.Length - 1; l >= 0; l--)
            {
                passws += userInput[l];
            }
            int attempts = 4;
            while (attempts > 0)
            {
                attempts -- ;
                string passwsInput = Console.ReadLine();
                if (passws == passwsInput)
                {
                    isRealUser = true;
                    break;

                }
                else 
                {
                    if (attempts == 0)
                    {
                        Console.WriteLine($"User {userInput} blocked!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }






































                }
                
               
            }
            
                

               
               
            
            if (isRealUser)
            {
                Console.WriteLine($"User {userInput} logged in.");
            }
           



        }
    }
}
