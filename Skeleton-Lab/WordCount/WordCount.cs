namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {

            using (StreamWriter sw = new StreamWriter(outputFilePath))
            {
                Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
                using (StreamReader sw1 = new StreamReader(wordsFilePath))
                {
                    string[] wordsWords = sw1.ReadToEnd().Split().ToArray();
                    using (StreamReader sw2 = new StreamReader(textFilePath))
                    {
                        string[] wordsText = sw2.ReadToEnd().Split(new string[] { " ", "-", ",", ".", "!", "...", "?" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                        for (global::System.Int32 i = 0; i < wordsWords.Length; i++)
                        {
                            string word = string.Empty;

                        
                            for (global::System.Int32 j = 0; j < wordsText.Length; j++)
                            {
                                if (wordsWords[i].ToLower() == wordsText[j].ToLower())
                                {
                                    word = wordsWords[i];

                                    if (!keyValuePairs.ContainsKey(word))
                                    {
                                        keyValuePairs.Add(word, 0);
                                    }
                                    keyValuePairs[word]++;
                                }
                            }

                          

                        }


                    }
                }
                foreach (var item in keyValuePairs.OrderByDescending(x => x.Value))
                {
                    sw.WriteLine($"{item.Key} - {item.Value}");
                }
            }

        }
    }
}
