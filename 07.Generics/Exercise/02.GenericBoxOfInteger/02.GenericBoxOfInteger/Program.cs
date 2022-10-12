using System;

namespace _02.GenericBoxOfInteger
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            int count = int.Parse(Console.ReadLine());

            for(int i=0; i<count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                box.Items.Add(num);
            }
            Console.WriteLine(box.ToString());
        }
    }
}

