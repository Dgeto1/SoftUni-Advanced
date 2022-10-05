using System;

namespace _01.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] segments = Console.ReadLine().Split();
            for(int i=0; i<segments.Length; i++)
            {
                Console.WriteLine(segments[i]);
            }
        }
    }
}

