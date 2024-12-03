namespace MergeFiles
{
    using System;
    using System.IO;
    using System.Linq;

    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {

            using (StreamWriter sw = new StreamWriter(outputFilePath))
            {

                using (StreamReader sr1 = new StreamReader(firstInputFilePath))
                {
                    using (StreamReader sr2 = new StreamReader(secondInputFilePath))
                    {

                        string firstLine = sr1.ReadLine();
                        string SecondLine = sr2.ReadLine();
                        while (firstLine != null && SecondLine != null)
                        {
                            sw.WriteLine(firstLine);
                            sw.WriteLine(SecondLine);

                            firstLine = sr1.ReadLine();
                            SecondLine = sr2.ReadLine();
                        }
                        if (firstLine == null)
                        {
                            while (SecondLine != null)
                            {
                                sw.WriteLine(SecondLine);
                                SecondLine = sr2.ReadLine();
                            }
                        }
                        else
                        {
                            while (firstLine != null)
                            {
                                sw.WriteLine(firstLine);
                                firstLine = sr2.ReadLine();
                            }
                        }

                    }

                }

            }
        }
    }
}
