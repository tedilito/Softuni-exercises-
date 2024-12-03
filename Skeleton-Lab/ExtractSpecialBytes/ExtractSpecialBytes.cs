namespace ExtractSpecialBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            byte[] binaryData = File.ReadAllBytes(binaryFilePath);

            byte[] bytesToExtract = File.ReadAllLines(bytesFilePath)
                                    .Select(byte.Parse)
                                    .ToArray();
            List<byte> extractedBytes = new List<byte>();


            foreach (byte b in binaryData)
            {
                if (bytesToExtract.Contains(b))
                {
                    extractedBytes.Add(b);
                }
            }
            File.WriteAllBytes(outputPath, extractedBytes.ToArray());


        }
    }
}
