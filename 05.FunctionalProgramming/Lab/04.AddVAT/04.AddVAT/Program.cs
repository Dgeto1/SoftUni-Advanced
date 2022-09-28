using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();
            for(int i=0; i<numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i] + (0.2 * numbers[i]):f2}");
            }
        }
    }
}

