using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            List<int> evenNumbers = new List<int>();
            for(int i=0; i<numbers.Length; i++)
            {
                if (numbers[i]%2==0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }
            evenNumbers = evenNumbers.OrderBy(x => x).ToList();
            Console.WriteLine(String.Join(", ", evenNumbers));
        }
    }
}

