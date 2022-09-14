using System;
using System.Collections.Generic;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            for(int i=1; i<=n;i++)
            {
                string[] segments = Console.ReadLine().Split();
                int command = int.Parse(segments[0]);
                if(command==1)
                {
                    numbers.Push(int.Parse(segments[1]));
                }
                else if(command==2)
                {
                    numbers.Pop();
                }
                else if(command==3)
                {
                    if(numbers.Count>0)
                    {
                        int maxNumber = numbers.Pop();
                        while()
                    }
                }
            }
        }
    }
}

