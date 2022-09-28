﻿namespace LineNumbers
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
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int row = 1;
                    string line = reader.ReadLine();
                    while(line!=null)
                    {
                        writer.WriteLine($"{row}. {line}");
                        line = reader.ReadLine();
                        row++;
                    }
                }
            }
        }
    }
}
