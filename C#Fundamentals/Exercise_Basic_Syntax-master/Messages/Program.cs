namespace Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int times = int.Parse(Console.ReadLine());
            string word = "";
            for (int i = 0; i < times; i++)
            {
                string numInput = Console.ReadLine();
                int numLenght = numInput.Length;
                int mainDigit = numInput[0] - '0';
               

                if (mainDigit == 8 || mainDigit == 9)
                {
                    int offSet = (mainDigit - 2) * 3;
                    offSet++;
                    int indexLetter = offSet + numLenght - 1;
                    char letter = (char)(97 + indexLetter );
                    word += letter;
                    
                }
                else if (mainDigit == 0)
                {
                    word += ' ';
                }
                else
                {
                    int offSet = (mainDigit - 2) * 3;
                  
                    int indexLetter = offSet + numLenght - 1;
                    char letter = (char)(97 + indexLetter );
                    word += letter;
                }


            }
            Console.WriteLine(word);
        }
    }
}
