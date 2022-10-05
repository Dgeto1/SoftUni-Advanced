using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseEndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());

            for(int i=0; i<numbers.Count; i++)
            {
                if (numbers[i]%num==0)
                {
                    numbers.Remove(numbers[i]);
                    i--;
                }
            }
            numbers.Reverse();

            foreach(var x in numbers)
            {
                Console.Write(x + " ");
            }
        }
    }
}

