using System;
using System.Linq;

namespace _07.PredicateforNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            for(int i=0; i<names.Length; i++)
            {
                if (names[i].Length<=lenght)
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }
}

