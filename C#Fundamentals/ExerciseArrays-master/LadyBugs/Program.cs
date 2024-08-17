namespace LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtField = int.Parse(Console.ReadLine());
            int[] bugPlace = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[lenghtField];

            for (int i = 0; i < bugPlace.Length; i++)
            {
                int bugIndex = bugPlace[i];
                if (bugIndex >= 0 && bugIndex <= field.Length - 1)
                {
                    field[bugIndex] = 1;
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                int bugIndex = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);


                if (bugIndex < 0 || bugIndex > field.Length - 1 || field[bugIndex] == 0)
                {
                    continue;
                }

                field[bugIndex] = 0;
                int lastIndex = field.Length - 1;
                if (direction == "right")
                {
                    int currLand = bugIndex + flyLength;
                    if (currLand > field.Length - 1)
                    {
                        continue;
                    }

                    if (field[currLand] == 1)
                    {
                        while (field[currLand] == 1)
                        {
                            currLand += flyLength;

                            if (currLand > field.Length - 1)
                            {
                                break;
                            }
                        }

                       



                    }
                    if (currLand <= field.Length - 1)
                    {
                        field[lenghtField] = 1;
                    }

                }
                else if (direction == "left")
                {
                    int currLand = bugIndex - flyLength;
                    if (currLand < 0)
                    {
                        continue;
                    }

                    if (field[currLand] == 1)
                    {
                        while (field[currLand] == 1)
                        {
                            currLand -= flyLength;

                            if (currLand < 0)
                            {
                                break;
                            }
                        }

                       
                    }

                    if (currLand >= 0)
                    {
                        field[lenghtField] = 1;
                    }
                }

            }


            Console.WriteLine(string.Join(" ", field));


        }
    }
}