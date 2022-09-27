using System;
using System.Linq;

namespace _03.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(numbers.Length<3)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
            else
            {
                numbers = numbers.OrderByDescending(x => x).ToArray();
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}

