using System;
using System.Collections.Generic;

namespace _07.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> carNumbers = new List<string>();

            string commands;
            while((commands=Console.ReadLine())!="END")
            {
                string[] segments = commands.Split(", ");
                string command = segments[0];
                string carNumber = segments[1];
                if(command=="IN")
                {
                    carNumbers.Add(carNumber);
                }
                else
                {
                    carNumbers.Remove(carNumber);
                }
            }
            if(carNumbers.Count<=0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var x in carNumbers)
                {
                    Console.WriteLine(x);
                }
            }   
        }
    }
}

