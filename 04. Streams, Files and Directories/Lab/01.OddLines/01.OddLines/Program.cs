using System;
using System.IO;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
           using(StreamReader reader = new StreamReader("../../../input.txt"))
           {
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    int row = 0;
                    while(!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if(row % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        row++;
                    }
                }
           }
        }
    }
}

