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
            List<string> words = new List<string>();
            List<string> text = new List<string>();
            using (StreamReader reader = new StreamReader(wordsFilePath))
            {
                using (StreamReader readerText = new StreamReader(textFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        string line = reader.ReadLine();
                        while(line!=null)
                        {
                            string[] word = line.Split();
                            for(int i=0; i<words.Length; i++)
                            {
                                words.Add(word[i]);
                            }
                        }
                        string st = readerText.ReadLine();
                        while(st!=null)
                        {
                            string[] word = st.Split();
                            for (int i = 0; i < words.Length; i++)
                            {
                                text.Add(word[i]);
                            }
                        }
                        for(int i=0; i<words.Count; i++)
                        {
                            for(int j=0; j<text; j++)
                            {

                            }
                        }
                    }
                }
            }
        }
    }
}
