namespace DirectoryTraversal
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string directoryPath = Console.ReadLine(); 
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string reportPath = Path.Combine(desktopPath, "report.txt");

            TraverseDirectory(directoryPath, reportPath);
        }

        public static void TraverseDirectory(string directoryPath, string reportPath)
        {
            Dictionary<string, List<FileInfo>> filesByExtension = new Dictionary<string, List<FileInfo>>();

            DirectoryInfo directory = new DirectoryInfo(directoryPath);
            FileInfo[] files = directory.GetFiles(); 

            foreach (FileInfo file in files)
            {
                string extension = file.Extension;

                if (!filesByExtension.ContainsKey(extension))
                {
                    filesByExtension[extension] = new List<FileInfo>();
                }

                filesByExtension[extension].Add(file);
            }

            using (StreamWriter writer = new StreamWriter(reportPath))
            {
                foreach (var extensionGroup in filesByExtension.OrderByDescending(g => g.Value.Count).ThenBy(g => g.Key))
                {
                    writer.WriteLine(extensionGroup.Key);

                    foreach (FileInfo file in extensionGroup.Value.OrderByDescending(f => f.Length).ThenBy(f => f.Name))
                    {
                        writer.WriteLine($"--{file.Name} - {file.Length / 1024.0:F3}kb");
                    }
                }
            }
        }
    }
}
