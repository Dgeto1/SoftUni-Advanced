using System;
using System.Linq;

namespace _04.GenericSwapMethodInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            int count = int.Parse(Console.ReadLine());
            for(int i=0; i<count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                box.Items.Add(num);
            }
            int[] segments = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Swap(segments[0], segments[1]);
            Console.WriteLine(box.ToString());
            Console.Read();
        }
    }
}

