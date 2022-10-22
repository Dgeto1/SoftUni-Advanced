using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.EnergyDrinks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> caffeine = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Queue<int> energyDrinks = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            int stamatCaffeine = 0;

            while(caffeine.Any() && energyDrinks.Any())
            {
                int currentCaffeine = caffeine.Peek();
                int currentEnergyDrink = energyDrinks.Peek();
                int total = currentCaffeine * currentEnergyDrink;

                if(stamatCaffeine+total<=300)
                {
                    stamatCaffeine += total;
                    caffeine.Pop();
                    energyDrinks.Dequeue();
                }
                else
                {
                    caffeine.Pop();
                    int drink = energyDrinks.Dequeue();
                    energyDrinks.Enqueue(drink);
                    stamatCaffeine -= 30;
                    if(stamatCaffeine<0)
                    {
                        stamatCaffeine = 0;
                    }
                }
            }
            if(energyDrinks.Any())
            {
                Console.WriteLine($"Drinks left: {String.Join(", ", energyDrinks)}");
            }
            else
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }
            Console.WriteLine($"Stamat is going to sleep with {stamatCaffeine} mg caffeine.");
            Console.Read();
        }
    }
}

