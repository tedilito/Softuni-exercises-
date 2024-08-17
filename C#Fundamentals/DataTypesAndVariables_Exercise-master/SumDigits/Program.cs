namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            //string inputInString = input.ToString();
            int result = 0;
            //for (int i = 0; i < inputInString.Length; i++)
            //{
            //    result +=  (inputInString[i] - '0';
            //}
            //Console.WriteLine(result);

            while (input > 0) 
            {
                int num = input % 10;
                input /= 10;
                 result += num;
            }
            Console.WriteLine(result);


        }
    }
}
