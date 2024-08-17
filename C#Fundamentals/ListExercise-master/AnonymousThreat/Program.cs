

namespace AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            List<string> list = input.Split().ToList();


            string commands;
            while ((commands = Console.ReadLine()) != "3:1")
            {
                string[] Arguments = commands.Split();


                switch (Arguments[0])
                {
                    case "merge":
                        int startIdndex = int.Parse(Arguments[1]);
                        int endIndex = int.Parse((Arguments[2]));
                        list = MergerInput(startIdndex, endIndex, input, list);

                        break;

                    case "divide":
                        int index = int.Parse((Arguments[1]));
                        int partitions = int.Parse((Arguments[2]));
                        break;


                }


            }
            Console.WriteLine(string.Join(" ", list));
        }

        private static List<string> MergerInput(int startIdndex, int endIndex, string input, List<string> list)
        {

            return; 

        }
    }
}
