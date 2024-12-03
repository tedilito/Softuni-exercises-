namespace PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int countExceptions = 0;
            while (countExceptions <  3)
            {
                string[] commands = Console.ReadLine().Split();
                try
                {
                    int index = int.Parse(commands[1]);
                   
                    switch (commands[0])
                    {
                        case "Replace":
                            int element = int.Parse(commands[2]);
                            numbers[index] = element;
                            break;


                        case "Print":
                            int endIndex = int.Parse(commands[2]);
                            if (index < 0 || endIndex >= numbers.Count)
                            {
                                throw new ArgumentOutOfRangeException();
                            }
                            for (global::System.Int32 i = index; i <= endIndex; i++)
                            {
                                if (i == endIndex)
                                {
                                    Console.Write(numbers[i]);
                                }
                                else
                                {
                                    Console.Write($"{numbers[i]}, ");
                                }
                            }
                            Console.WriteLine();
                            break;


                        case "Show":
                            Console.WriteLine(numbers[index]);
                            break;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("The index does not exist!");
                    countExceptions++;
                   
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    countExceptions++;
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
