
namespace GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(num1, num2)); 

            }
            else if (type == "char")
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());
               
                Console.WriteLine(GetMax(char1, char2));
            }
            else if (type == "string")
            {
                string str = Console.ReadLine();
                string str2 = Console.ReadLine();
                Console.WriteLine(GetMax(str, str2));
                
            }



        }

        private static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        private static char GetMax(char char1, char char2)
        {
            if (char1 > char2)
            {
                return char1;
            }
            else
            {
                return char2;
            }
        }

        private static string GetMax(string str, string str2)
        {
            if (str.CompareTo(str2) == 1)
            {
                return str;
            }
            else
            {
                return str2;
            }
        }

    }
}
