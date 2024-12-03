namespace LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            string[] output = new string[lines.Length];
            int linesNum = 0;
           
            foreach (string line in lines)
            {
                int countLetters = 0;
                int countPuntc = 0;
                foreach (char letter in line)
                {
                    if (char.IsLetter(letter))
                    {
                        countLetters++;
                    }
                    else if (char.IsPunctuation(letter))
                    {
                        countPuntc++;
                    }
                }
                output[linesNum] = $"Line {++linesNum}: {line} ({(countLetters)})({(countPuntc)})";
            }
            File.WriteAllLines(outputFilePath, output);
        }
    }
}
