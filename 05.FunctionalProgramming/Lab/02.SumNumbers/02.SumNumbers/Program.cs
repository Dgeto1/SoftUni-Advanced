using System;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Console.WriteLine(numbers.Length);
            int sum = 0;
            for(int i=0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}

