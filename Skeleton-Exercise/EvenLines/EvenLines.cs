namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using (StreamReader stw = new StreamReader(inputFilePath))
            {
                string result = string.Empty;
                string line = stw.ReadLine();
                int lineNum = 0;
                while (line != null)
                {
                    
                   
                    if (lineNum % 2 == 0)
                    {

                        string[] chars = new string[] { ",", ", ", "-", ".", "!", "?" };
                        foreach (var Char in chars)
                        {
                            if (line.Contains(Char))
                            {
                                line = line.Replace(Char, "@");
                            }
                        }
                        string[] strings = line.Split();
                        line = string.Empty;
                        for (global::System.Int32 i = (strings.Length) - (1); i >= 0; i--)
                        {
                            line += strings[i] + " ";
                        }
                    
                        result += line + "\n";
                    }

                    lineNum++;
                    line = stw.ReadLine();
                }

                return result;
            }
           
        }
    }
}
