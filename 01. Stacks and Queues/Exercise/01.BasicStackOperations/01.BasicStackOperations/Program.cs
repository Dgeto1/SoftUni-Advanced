using System;
using System.Collections.Generic;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] segments = Console.ReadLine().Split();
            int numberElements = int.Parse(segments[0]);
            int numbersPop = int.Parse(segments[1]);
            int searchingNumber = int.Parse(segments[2]);

            string[] numbersToAdd = Console.ReadLine().Split();
            Stack<int> numbers = new Stack<int>();

            for(int i=0; i<numberElements; i++)
            {
                numbers.Push(int.Parse(numbersToAdd[i]));
            }
            while(numbersPop>0)
            {
                numbers.Pop();
                numbersPop--;
            }
            if(numbers.Count==0)
            {
                Console.WriteLine(0);
                return;
            }
            if(numbers.Contains(searchingNumber))
            {
                Console.WriteLine("true");
            }
            else
            {
                int minNumber = numbers.Pop();
                while(numbers.Count>0)
                {
                    int num = numbers.Pop();
                    if(num<minNumber)
                    {
                        minNumber = num;
                    }
                }
                Console.WriteLine(minNumber);
            }
        }
    }
}

