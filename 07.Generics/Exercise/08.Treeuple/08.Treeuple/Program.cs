using System;

namespace _08.Treeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            string[] secondLine = Console.ReadLine().Split();
            string[] thirdLine = Console.ReadLine().Split();

            Threeuple<string, string, string> address = new Threeuple<string, string, string>
            {
                Item1 = $"{firstLine[0]} {firstLine[1]}",
                Item2 = $"{firstLine[2]}",
                Item3 = $"{firstLine[3]}"
            };
            Threeuple<string, int, bool> drink = new Threeuple<string, int, bool>
            {
                Item1 = $"{secondLine[0]}",
                Item2 = int.Parse(secondLine[1]),
                Item3 = secondLine[2] == "drunk"
            };
            Threeuple<string, double, string> bank = new Threeuple<string, double, string>
            {
                Item1 = $"{thirdLine[0]}",
                Item2 = double.Parse(thirdLine[1]),
                Item3 = $"{thirdLine[2]}"
            };

            Console.WriteLine(address.ToString());
            Console.WriteLine(drink.ToString());
            Console.WriteLine(bank.ToString());
        }
    }
}

