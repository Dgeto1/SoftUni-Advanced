using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                List<string> segments = Console.ReadLine().Split().ToList();
                string name = segments[0];
                double grade = double.Parse(segments[1]);
                if(!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<double>());
                    studentGrades[name].Add(grade);
                }
                else
                {
                    studentGrades[name].Add(grade);
                }
            }
            foreach(var x in studentGrades)
            {
                double average = 0;
                Console.Write($"{x.Key} -> ");
                for(int i = 0;i<x.Value.Count;i++)
                {
                    average += x.Value[i];
                    Console.Write($"{x.Value[i]:f2} ");
                }
                Console.Write($"(avg: {average / x.Value.Count:f2})");
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}

