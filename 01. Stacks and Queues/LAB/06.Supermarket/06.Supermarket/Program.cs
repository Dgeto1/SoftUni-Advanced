using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();
            string command;
            while((command=Console.ReadLine())!="End")
            {
                if(command=="Paid")
                {
                    while(customers.Count>0)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
                else
                {
                    customers.Enqueue(command);
                }
            }
            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}

