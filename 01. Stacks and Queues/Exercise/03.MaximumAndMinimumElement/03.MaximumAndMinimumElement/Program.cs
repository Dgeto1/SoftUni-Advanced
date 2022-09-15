using System;
using System.Collections.Generic;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            for(int i=1; i<=n;i++)
            {
                string[] segments = Console.ReadLine().Split();
                int command = int.Parse(segments[0]);
                if(command==1)
                {
                    numbers.Push(int.Parse(segments[1]));
                }
                else if(command==2)
                {
                    numbers.Pop();
                }
                else if(command==3)
                {
                    if(numbers.Count>0)
                    {
                        Stack<int> maxNumber = new Stack<int>(numbers);
                        int maxNum = maxNumber.Pop();
                        while(maxNumber.Count>0)
                        {
                            int num = maxNumber.Pop();
                            if(num>maxNum)
                            {
                                maxNum = num;
                            }
                        }
                        Console.WriteLine(maxNum);
                    }
                }
                else if(command==4)
                {
                    if (numbers.Count > 0)
                    {
                        Stack<int> minNumber = new Stack<int>(numbers);
                        int minNum = minNumber.Pop();
                        while (minNumber.Count > 0)
                        {
                            int num = minNumber.Pop();
                            if (num < minNum)
                            {
                                minNum = num;
                            }
                        }
                        Console.WriteLine(minNum);
                    }
                }
            }
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}

