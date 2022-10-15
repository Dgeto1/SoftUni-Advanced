using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _01.TilesMaster2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> whites = Console.ReadLine().Split().Select(int.Parse).ToList();
            whites.Reverse();
            List<int> greys = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sink = 0, oven = 0, countertop = 0, wall = 0, floor = 0;
            if(whites.Count>=greys.Count)
            {
                for(int i=0; i<whites.Count; i++)
                {
                    int sum = 0;
                    if(greys.Count<=0)
                    {
                        break;
                    }
                    if (whites[i] == greys[i])
                    {
                        sum = whites[i] * 2;
                        switch (sum)
                        {
                            case 40:
                                sink++;
                                whites.Remove(whites[i]);
                                greys.Remove(greys[i]);
                                break;

                            case 50:
                                oven++;
                                whites.Remove(whites[i]);
                                greys.Remove(greys[i]);
                                break;

                            case 60:
                                countertop++;
                                whites.Remove(whites[i]);
                                greys.Remove(greys[i]);
                                break;

                            case 70:
                                wall++;
                                whites.Remove(whites[i]);
                                greys.Remove(greys[i]);
                                break;
                            default:
                                whites.Remove(whites[i]);
                                greys.Remove(greys[i]);
                                floor++;
                                break;
                        }
                    }
                    else
                    {
                        whites[i] /= 2;
                        int greyEl = greys[i];
                        greys.Remove(greyEl);
                        greys.Add(greyEl);
                    }
                    i--;
                }
            }
            else
            {
                for (int i = 0; i < greys.Count; i++)
                {
                    int sum = 0;
                    if (whites.Count <= 0)
                    {
                        break;
                    }
                    if (whites[i] == greys[i])
                    {
                        sum = whites[i] * 2;
                        switch (sum)
                        {
                            case 40:
                                sink++;
                                whites.Remove(whites[i]);
                                greys.Remove(greys[i]);
                                break;

                            case 50:
                                oven++;
                                whites.Remove(whites[i]);
                                greys.Remove(greys[i]);
                                break;

                            case 60:
                                countertop++;
                                whites.Remove(whites[i]);
                                greys.Remove(greys[i]);
                                break;

                            case 70:
                                wall++;
                                whites.Remove(whites[i]);
                                greys.Remove(greys[i]);
                                break;
                            default:
                                whites.Remove(whites[i]);
                                greys.Remove(greys[i]);
                                floor++;
                                break;
                        }
                    }
                    else
                    {
                        whites[i] /= 2;
                        int greyEl = greys[i];
                        greys.Remove(greyEl);
                        greys.Add(greyEl);
                    }
                    i--;
                }
            }
            if (whites.Count > 0)
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
            Dictionary<string, int> places = new Dictionary<string, int>();
            places.Add("Sink", sink);
            places.Add("Oven", oven);
            places.Add("Countertop", countertop);
            places.Add("Wall", wall);
            places.Add("Floor", floor);
            foreach(var x in places)
            {
                if(x.Value==0)
                {
                    places.Remove(x.Key);
                }
            }
            places = places.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).ToDictionary(x=>x.Key, x=>x.Value);
            foreach(var x in places)
            {
                Console.WriteLine($"{x.Key}: {x.Value}");
            }
        }
    }
}

