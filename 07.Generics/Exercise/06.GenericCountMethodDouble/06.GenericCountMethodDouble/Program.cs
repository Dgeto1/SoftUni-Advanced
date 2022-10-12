using System;

namespace _06.GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                double value = double.Parse(Console.ReadLine());
                box.Items.Add(value);
            }
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine(box.Count(num));
        }
    }
}

