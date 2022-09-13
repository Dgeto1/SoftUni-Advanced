using System;
using System.Collections.Generic;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> nums = new Queue<int>();
            string[] numbers = Console.ReadLine().Split();
            foreach(var x in numbers)
            {
                if(int.Parse(x)%2==0)
                {
                    nums.Enqueue(int.Parse(x));
                }
            }
            Console.WriteLine(String.Join(", ", nums));
        }
    }
}

