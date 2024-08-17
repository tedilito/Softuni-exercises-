
namespace CharsInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());

            CharsInRange(input1, input2);
        }

        private static void CharsInRange(char input1, char input2)
        {
            char result;


            if (input2 < input1)
            {
                for (int i = input2 + 1; i < input1; i++)
                {

                    Console.Write(Convert.ToChar(i) + " ");
                }
            }
            else
            {
                for (int i = input1 + 1; i < input2; i++)
                {
                    Console.Write(Convert.ToChar(i) + " ");
                }
            }
        }
    }
}
