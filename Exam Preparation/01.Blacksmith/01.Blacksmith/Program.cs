using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Blacksmith
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> swordValues = new Dictionary<string, int>
            {
                { "Gladius", 0},
                { "Shamshir", 0},
                { "Katana", 0},
                { "Sabre", 0},
                { "Broadsword", 0}
            };

            Queue<int> steal = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> carbon = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            int countForgedSwords = 0;

            while(steal.Any() && carbon.Any())
            {
                int currentSteal = steal.Peek();
                int currentCarbon = carbon.Peek();
                int total = currentSteal + currentCarbon;

                if(total==70)
                {
                    swordValues["Gladius"]++;
                    steal.Dequeue();
                    carbon.Pop();
                    countForgedSwords++;
                }
                else if(total==80)
                {
                    swordValues["Shamshir"]++;
                    steal.Dequeue();
                    carbon.Pop();
                    countForgedSwords++;
                }
                else if(total==90)
                {
                    swordValues["Katana"]++;
                    steal.Dequeue();
                    carbon.Pop();
                    countForgedSwords++;
                }
                else if(total==110)
                {
                    swordValues["Sabre"]++;
                    steal.Dequeue();
                    carbon.Pop();
                    countForgedSwords++;
                }
                else if(total==150)
                {
                    swordValues["Broadsword"]++;
                    steal.Dequeue();
                    carbon.Pop();
                    countForgedSwords++;
                }
                else
                {
                    steal.Dequeue();
                    int carbonValue = carbon.Pop();
                    carbon.Push(carbonValue + 5);
                }
            }
            if(countForgedSwords>0)
            {
                Console.WriteLine($"You have forged {countForgedSwords} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }

            if(steal.Count>0)
            {
                Console.WriteLine($"Steel left: {String.Join(", ", steal)}");
            }
            else
            {
                Console.WriteLine("Steel left: none");
            }

            if (carbon.Count > 0)
            {
                Console.WriteLine($"Carbon left: {String.Join(", ", carbon)}");
            }
            else
            {
                Console.WriteLine("Carbon left: none");
            }

            swordValues = swordValues.Where(x => x.Value > 0).OrderBy(x=>x.Key).ToDictionary(x=>x.Key, x=>x.Value);

            foreach(var x in swordValues)
            {
                Console.WriteLine($"{x.Key}: {x.Value}");
            }
            Console.Read();
        }
    }
}

