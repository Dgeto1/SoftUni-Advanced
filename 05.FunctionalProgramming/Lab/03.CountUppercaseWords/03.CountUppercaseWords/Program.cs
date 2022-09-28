using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            for(int i=0; i<words.Length; i++)
            {
                if (Char.IsUpper(words[i][0]))
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}

