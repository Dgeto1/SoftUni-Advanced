using System;
using System.Collections.Generic;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                string[] segments = Console.ReadLine().Split();
                int amountPetrol = int.Parse(segments[0]);
                int distanceBetweenPump = int.Parse(segments[1]);
            }
        }
    }
}

