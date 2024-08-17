namespace Digits_LettersAndOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string nums = string.Empty;
            string letters = string.Empty;
            string others = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    nums += input[i];
                }
                else if (char.IsLetter(input[i]))
                {
                    letters += input[i];
                }
                else
                {
                    others += input[i];
                }
            }
            Console.WriteLine(nums);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
