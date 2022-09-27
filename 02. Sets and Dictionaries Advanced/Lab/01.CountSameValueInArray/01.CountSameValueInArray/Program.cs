using System;
using System.Collections.Generic;

namespace _01.CountSameValueInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> values = new Dictionary<double, int>();
            string[] segments = Console.ReadLine().Split();

            for(int i=0; i<segments.Length;i++)
            {
                double value = double.Parse(segments[i]);
                if(!values.ContainsKey(value))
                {
                    values.Add(value, 1);
                }
                else
                {
                    values[value]++;
                }
            }
            foreach(var x in values)
            {
                Console.WriteLine($"{x.Key} - {x.Value} times");
            }
        }
    }
}

