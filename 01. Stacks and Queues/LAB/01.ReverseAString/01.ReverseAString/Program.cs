using System;
using System.Collections.Generic;

namespace _01.ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> symbols = new Stack<char>();
            string input = Console.ReadLine();
            for(int i=0; i<input.Length;i++)
            {
                symbols.Push(input[i]);
            }
            while(symbols.Count>0)
            {
                Console.Write(symbols.Pop());
            }
        }
    }
}

