using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;
            while((command = Console.ReadLine())!="end")
            {
                switch (command)
                {
                    case "add":
                        for(int i=0; i<numbers.Count; i++)
                        {
                            numbers[i] += 1;
                        }
                        break;
                    case "multiply":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers[i] *= 2;
                        }
                        break; ;
                    case "subtract":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers[i] -= 1;
                        }
                        break;
                    case "print":
                        foreach(var x in numbers)
                        {
                            Console.Write(x + " ");
                        }
                        break;
                }
            }
        }
    }
}

