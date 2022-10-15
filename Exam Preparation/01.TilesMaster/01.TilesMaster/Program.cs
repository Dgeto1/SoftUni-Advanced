using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TilesMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> whites = new Stack<int>();
            Queue<int> greys = new Queue<int>();

            int sink = 0, oven = 0, countertop = 0, wall = 0, floor = 0;

            int[] white = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] grey = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for(int i=0; i<white.Length; i++)
            {
                whites.Push(i);
            }
            for(int i=0; i<grey.Length; i++)
            {
                greys.Enqueue(i);
            }

            foreach(var x in whites)
            {
                if(greys.Contains(x))
                {
                    int sum = 2 * whites.Peek();
                    switch (sum)
                    {
                        case 40:
                            sink++;
                            whites.Pop();
                            greys.Dequeue();
                            break;

                        case 50:
                            oven++;
                            whites.Pop();
                            greys.Dequeue();
                            break;

                        case 60:
                            countertop++;
                            whites.Pop();
                            greys.Dequeue();
                            break;

                        case 70:
                            wall++;
                            whites.Pop();
                            greys.Dequeue();
                            break;
                        default:
                            floor++;
                            break;
                    }
                }
                else
                {
                    int num = whites.Pop()/2;
                    whites.Push(num);
                }
            }
            if(whites.Count>0)
            {
                Console.WriteLine($"White tiles left: {String.Join(", ", whites)}");
            }
            else
            {
                Console.WriteLine("White tiles left: none");
            }

            if (greys.Count > 0)
            {
                Console.WriteLine($"Grey tiles left: {String.Join(", ", greys)}");
            }
            else
            {
                Console.WriteLine("Grey tiles left: none");
            }
            SortedDictionary<string, int> places = new SortedDictionary<string, int>();
            places.Add("Sink", sink);
            places.Add("Oven", oven);
            places.Add("Countertop", countertop);
            places.Add("Wall", wall);
            places.Add("Floor", floor);
            places.Reverse();

            foreach(var x in places)
            {
                Console.WriteLine($"{x.Key}: {x.Value}");
            }
            Console.Read();
        }
    }
}

