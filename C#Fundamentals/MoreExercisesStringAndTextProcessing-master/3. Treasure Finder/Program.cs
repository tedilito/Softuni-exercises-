namespace _3._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keyValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string result = string.Empty;
            string type = string.Empty;
            string coordinates = string.Empty;
            string input;
            while ((input = Console.ReadLine()) != "find")
            {
                string[] strings = input.Split("");
                if (keyValues.Length < input.Length)
                {
                    for ( int i = 0; i < keyValues.Length; i++)
                    {
                        for (int j = 0; j < input.Length; j++)
                        {
                            result += (char)(input[j] - keyValues[i]);
                            i++;
                            if (i >= keyValues.Length)
                            {
                                i = 0;
                            }
                        }
                       // Console.WriteLine(result);
                        break;
                    }
                    for (int i = 0; i < result.Length; i++)
                    {
                        

                        if (result[i] == '&')
                        {
                            while (result[i + 1] != '&')
                            {
                                type += result[i + 1];
                                
                                i++;
                            }
                            i++;
                        }

                        if (result[i] == '<')
                        {
                            while (result[i + 1] != '>')
                            {
                                coordinates += result[i + 1];
                                i++;
                            }
                        }

                    }
                    Console.WriteLine($"Found {type} at {coordinates}");
                    result = string.Empty;
                    type = string.Empty;
                    coordinates = string.Empty;
                }
            }
            


        }
    }
}
