namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {

            using (StreamWriter sw = new StreamWriter(outputFilePath))
            {
                using (StreamReader sr = new StreamReader(inputFilePath))
                {
                    string text = sr.ReadLine();
                    int line = 0;
                    while (text != null)
                    {
                        sw.WriteLine($"{++line}. {text}");
                        
                        text = sr.ReadLine();
                    }
                }
            }


        }
    }
}
