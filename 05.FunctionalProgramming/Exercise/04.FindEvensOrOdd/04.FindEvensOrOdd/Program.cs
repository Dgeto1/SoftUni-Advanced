using System;
using System.Linq;

namespace _04.FindEvensOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] segments = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = segments[0];
            int end = segments[1];
            string command = Console.ReadLine();
            if(command == "odd")
            {
                for(int i=start; i<=end; i++)
                {
                    if(i%2!=0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                for(int i=start; i<=end; i++)
                {
                    if(i%2==0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}

