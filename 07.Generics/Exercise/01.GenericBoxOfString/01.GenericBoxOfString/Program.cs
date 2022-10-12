using System;
using System.Collections.Generic;

namespace _01.GenericBoxOfString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int count = int.Parse(Console.ReadLine());
            for(int i=0; i<count; i++)
            {
                string st = Console.ReadLine();
                box.Items.Add(st);
            }
            Console.WriteLine(box.ToString());
        }
    }
}

