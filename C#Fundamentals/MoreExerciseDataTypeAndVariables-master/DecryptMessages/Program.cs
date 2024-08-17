namespace DecryptMessages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string decrypted = "";
            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int valueOfChar = input;
                int decryptedValue = valueOfChar + key;
                 decrypted += (char)decryptedValue;
            }
            Console.WriteLine(decrypted);
        }
    }
}
