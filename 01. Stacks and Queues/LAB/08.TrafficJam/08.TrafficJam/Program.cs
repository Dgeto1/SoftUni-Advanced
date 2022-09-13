using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();

            int numberCarsPassing = int.Parse(Console.ReadLine());
            int passedCars = 0;

            string command;
            while((command=Console.ReadLine())!="end")
            {
                if(command == "green")
                {
                    int passing = numberCarsPassing;
                    while(passing>0)
                    {
                        if(cars.Count==0)
                        {
                            break;
                        }
                        string currentCar = cars.Dequeue();
                        Console.WriteLine($"{currentCar} passed!");
                        passedCars++;
                        passing--;
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }
            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}

