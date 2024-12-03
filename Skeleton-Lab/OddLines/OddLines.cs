namespace OddLines
{
    using System.IO;
    using System.Linq;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {



            using (StreamWriter outputWriter = new StreamWriter(outputFilePath)) 
            {
                using (StreamReader reader = new StreamReader(inputFilePath))
                {
                    int line = 0;
                    string text = reader.ReadLine();
                    while (text != null)
                    {
                        if (line++ % 2 != 0)
                        {
                            outputWriter.WriteLine(text);
                        }
                        text = reader.ReadLine();
                    }
                }
            }


        }
    }
}
