using System;
using System.Collections.Generic;

namespace _05.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> citiesContinets = new Dictionary<string, Dictionary<string, string>>();
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                string[] segments = Console.ReadLine().Split();
                string continent = segments[0];
                string country = segments[1];
                string city = segments[2];

                if(!citiesContinets.ContainsKey(continent))
                {
                    citiesContinets.Add(continent, new Dictionary<string, string>());
                    citiesContinets[continent].Add(country, city);
                }
                else if(citiesContinets.ContainsKey(continent) && citiesContinets.ContainsValue(country))
            }
        }
    }
}

