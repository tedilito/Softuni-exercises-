namespace SplitMergeBinaryFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            byte[] binaryData = File.ReadAllBytes(sourceFilePath);
            if (binaryData.Length % 2 == 0)
            {
                int middleNum = binaryData.Length / 2;
                List<byte> extractedBytes = new List<byte>();
                List<byte> extractedBytes2 = new List<byte>();


                for (global::System.Int32 i = 0; i < middleNum; i++)
                {
                    extractedBytes.Add(binaryData[i]);
                }
                for (global::System.Int32 i = middleNum; i < binaryData.Length; i++)
                {
                    extractedBytes2.Add(binaryData[i]);
                }

                File.WriteAllBytes(partOneFilePath, extractedBytes.ToArray());
                File.WriteAllBytes(partOneFilePath, extractedBytes2.ToArray());
            }
            else
            {
                int middleNum = binaryData.Length / 2;
                List<byte> extractedBytes = new List<byte>();
                List<byte> extractedBytes2 = new List<byte>();


                for (global::System.Int32 i = 0; i <= middleNum; i++)
                {
                    extractedBytes.Add(binaryData[i]);
                }
                for (global::System.Int32 i = middleNum + 1; i < binaryData.Length; i++)
                {
                    extractedBytes2.Add(binaryData[i]);
                }

                File.WriteAllBytes(partOneFilePath, extractedBytes.ToArray());
                File.WriteAllBytes(partTwoFilePath, extractedBytes2.ToArray());
            }


        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {

            byte[] binaryDataPartOne = File.ReadAllBytes(partOneFilePath);
            byte[] binaryDataPartTwo = File.ReadAllBytes(partTwoFilePath);

            File.WriteAllBytes(joinedFilePath, binaryDataPartOne.ToArray());
            File.WriteAllBytes(joinedFilePath, binaryDataPartTwo.ToArray());

        }
    }
}