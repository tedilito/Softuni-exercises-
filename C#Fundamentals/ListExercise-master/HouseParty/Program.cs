namespace HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> guests = new List<string>();


            int lenght = int.Parse(Console.ReadLine()); 
            for (int i = 0; i < lenght; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length <= 3)
                {
                    if (!guests.Contains(input[0]))
                    {
                        guests.Add(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                }
                else
                {
                    if (guests.Contains(input[0]))
                    {
                        guests.Remove(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                }
            }

            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
         
        }
    }
}
