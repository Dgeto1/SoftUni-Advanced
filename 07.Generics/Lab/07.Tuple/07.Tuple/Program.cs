using System;
using System.Linq;

namespace _07.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            string[] secondLine = Console.ReadLine().Split();
            string[] thirdLine = Console.ReadLine().Split();

            Tuple<string, string> nameAdress = new Tuple<string, string>
            {
                Item1 = $"{firstLine[0]} {firstLine[1]}",
                Item2 = $"{firstLine[2]}"
            };

            Tuple<string, int> personDrink = new Tuple<string, int>
            {
                Item1 = $"{secondLine[0]}",
                Item2 = int.Parse(secondLine[1])
            };

            Tuple<int, double> numbers = new Tuple<int, double>
            {
                Item1 = int.Parse(thirdLine[0]),
                Item2 = double.Parse(thirdLine[1])
            };
            Console.WriteLine(nameAdress.ToString());
            Console.WriteLine(personDrink.ToString());
            Console.WriteLine(numbers.ToString());
            Console.Read();
        }
    }
}

