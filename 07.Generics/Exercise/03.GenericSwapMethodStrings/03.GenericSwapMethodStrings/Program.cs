using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GenericSwapMethodStrings
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int count = int.Parse(Console.ReadLine());
            for(int i=0; i<count; i++)
            {
                string name = Console.ReadLine();
                box.Items.Add(name);
            }
            int[] segments = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Swap(segments[0], segments[1]);
            Console.WriteLine(box.ToString());
            Console.Read();
        }
    }
}

