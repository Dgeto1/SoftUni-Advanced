using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            Queue<string> children = new Queue<string>(kids);
            int tosses = 1;

            while(children.Count>1)
            {
                string currentKid = children.Dequeue();
                if(tosses==n)
                {
                    Console.WriteLine($"Removed {currentKid}");
                    tosses = 1;
                    continue;
                }
                tosses++;
                children.Enqueue(currentKid);
            }
            Console.WriteLine($"Last is {children.Peek()}");
        }
    }
}

