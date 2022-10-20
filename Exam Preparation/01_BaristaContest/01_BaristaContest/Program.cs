using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_BaristaContest
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> coffee = new Queue<int>();
            Stack<int> milk = new Stack<int>();

            int[] coffees = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] milks = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            for(int i=0; i<coffees.Length; i++)
            {
                coffee.Enqueue(coffees[i]);
            }
            for(int i=0; i<milks.Length; i++)
            {
                milk.Push(milks[i]);
            }


        }
    }
}

