namespace FolderSize
{
    using System;
    using System.IO;

    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
           
            long totalSize = CalculateFolderSize(folderPath);

           
            double sizeInKilobytes = totalSize / 1024.0;

            
            File.WriteAllText(outputFilePath, sizeInKilobytes.ToString("F10") + " KB");
        }

        private static long CalculateFolderSize(string folderPath)
        {
            long totalSize = 0;

          
            string[] files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);

           
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                totalSize += fileInfo.Length;
            }

            return totalSize;
        }
    }
}
