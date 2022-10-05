using System;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            for(int i=0; i<names.Length; i++)
            {
                Console.WriteLine($"Sir {names[i]}");
            }
        }
    }
}

