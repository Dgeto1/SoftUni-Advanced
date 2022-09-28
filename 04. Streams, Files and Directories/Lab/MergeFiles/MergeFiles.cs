namespace MergeFiles
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"../../../Files/input1.txt";
            var secondInputFilePath = @"../../../Files/input2.txt";
            var outputFilePath = @"../../../Files/output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            List<string> first = new List<string>();
            List<string> second = new List<string>();
            using (StreamReader firstReader = new StreamReader(firstInputFilePath))
            {
                using (StreamReader secondReader = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        string firtsLine = firstReader.ReadLine();
                        while(firtsLine!=null)
                        {
                            first.Add(firtsLine);
                            firtsLine = firstReader.ReadLine();
                        }
                        string secondLine = secondReader.ReadLine();
                        while(secondLine!=null)
                        {
                            second.Add(secondLine);
                            secondLine = secondReader.ReadLine();
                        }
                        bool firstBigger = true;
                        if(first.Count<second.Count)
                        {
                            firstBigger = false;
                        }
                        if(firstBigger)
                        {
                            for(int i=0; i<first.Count; i++)
                            {
                                {
                                    writer.WriteLine(first[i]);
                                    writer.WriteLine(second[i]);
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < second.Count; i++)
                            {
                               
                                {
                                    writer.WriteLine(first[i]);
                                    writer.WriteLine(second[i]);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
