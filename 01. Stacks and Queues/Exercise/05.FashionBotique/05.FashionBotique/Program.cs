using System;
using System.Collections.Generic;

namespace _05.FashionBotique
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] segments = Console.ReadLine().Split();
            Stack<int> values = new Stack<int>();
            for(int i=0; i<segments.Length;i++)
            {
                values.Push(int.Parse(segments[i]));
            }
            int capacityRack = int.Parse(Console.ReadLine());
            int usedRacks = 0;

            int cap = capacityRack;
            int sum = 0;
            while (values.Count>0)
            {
                
                sum = values.Pop();
                if(sum<cap)
                {
                    cap -= sum;
                }
                else if(sum==cap)
                {
                    cap -= sum;
                    usedRacks++;
                }
                else if(sum>cap)
                {
                    usedRacks++;
                    cap = capacityRack;
                    cap -= sum;
                }
            }
            Console.WriteLine(usedRacks);
        }
    }
}

