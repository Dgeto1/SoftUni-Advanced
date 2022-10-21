using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BakeryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var bekaryResult = new Dictionary<string, int>
            {
                {"Croissant", 0 },
                {"Muffin", 0 },
                {"Baguette", 0 },
                {"Bagel", 0 }
            };

            Queue<double> water = new Queue<double>(Console.ReadLine().Split().Select(double.Parse).ToArray());
            Stack<double> flour = new Stack<double>(Console.ReadLine().Split().Select(double.Parse).ToArray());

            while(water.Count() >0 && flour.Count() > 0)
            {
                double firstWater = water.Peek();
                double lastFlour = flour.Peek();

                double calc = firstWater + lastFlour;
                double waterPercent = (firstWater * 100) / calc;

                switch(waterPercent)
                {
                    case 50:
                        water.Dequeue();
                        flour.Pop();
                        bekaryResult["Croissant"]++;
                        break;
                    case 40:
                        water.Dequeue();
                        flour.Pop();
                        bekaryResult["Muffin"]++;
                        break;
                    case 30:
                        water.Dequeue();
                        flour.Pop();
                        bekaryResult["Baguette"]++;
                        break;
                    case 20:
                        water.Dequeue();
                        flour.Pop();
                        bekaryResult["Bagel"]++;
                        break;
                    default:
                        double oldFlour = lastFlour;
                        lastFlour = firstWater;
                        water.Dequeue();
                        flour.Pop();
                        bekaryResult["Croissant"]++;
                        oldFlour -= lastFlour;
                        flour.Push(oldFlour);
                        break;
                }

            }
            foreach(var x in bekaryResult)
            {
                if(x.Value==0)
                {
                    bekaryResult.Remove(x.Key);
                }
            }
            bekaryResult = bekaryResult.OrderByDescending(x => x.Value).ThenBy(x=>x.Key).ToDictionary(x=>x.Key, x=>x.Value);
            foreach(var x in bekaryResult)
            {
                Console.WriteLine($"{x.Key}: {x.Value}");
            }
            if(!water.Any())
            {
                Console.WriteLine("Water left: None");
            }
            else
            {
                Console.WriteLine($"Water left: {String.Join(", ", water)}");
            }
            if(!flour.Any())
            {
                Console.WriteLine("Flour left: None");
            }
            else
            {
                Console.WriteLine($"Flour left: {String.Join(", ", flour)}");
            }
            Console.Read();
        }
    }
}

