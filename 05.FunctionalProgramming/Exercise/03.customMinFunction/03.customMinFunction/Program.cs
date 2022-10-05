using System;
using System.Linq;

namespace _03.customMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int minNumber = numbers.Min();
            Console.WriteLine(minNumber);
        }
    }
}

