namespace GenericBoxOfString
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out int num))
                {
                    Box<int> box = new Box<int>(num);
                    box.Add();
                    Console.WriteLine(box.ToString());
                }
                else
                {
                    Box<string> box = new Box<string>(input);
                    box.Add();
                    Console.WriteLine(box.ToString());
                }
              
            }
            
        }
    }
}
