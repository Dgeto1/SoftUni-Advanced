using System;
using System.Collections.Generic;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            string[] input = Console.ReadLine().Split();
            for(int i=0; i<input.Length;i++)
            {
                numbers.Push(int.Parse(input[i]));
            }
            string commands;
            while((commands = Console.ReadLine())!="end")
            {
                string[] segments = commands.Split();
                string command = segments[0];
                switch (command)
                {
                    case "add":
                        numbers.Push(int.Parse(segments[1]));
                        numbers.Push(int.Parse(segments[2]));
                        break;
                    case "remove":
                        int countNumbers = int.Parse(segments[1]);
                        if(countNumbers<=numbers.Count)
                        {
                            while (countNumbers > 0)
                            {
                                numbers.Pop();
                                countNumbers--;
                            }
                        }
                        break;
                }
            }
            int sum = 0;
            while(numbers.Count>0)
            {
                sum += numbers.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

