using System;

namespace _05.GenericCountMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                box.Items.Add(name);
            }
            string st = Console.ReadLine();
            Console.WriteLine(box.Count(st));
            Console.Read();
        }
    }
}

