using System;
using System.Collections.Generic;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] segments = Console.ReadLine().Split();
            int countNums = int.Parse(segments[0]);
            int removeNums = int.Parse(segments[1]);
            int searchingNum = int.Parse(segments[2]);

            string[] nums = Console.ReadLine().Split();
            Queue<int> numbers = new Queue<int>();
            for(int i=0; i<nums.Length; i++)
            {
                numbers.Enqueue(int.Parse(nums[i]));
            }
            while(removeNums>0)
            {
                numbers.Dequeue();
                removeNums--;
            }
            if (numbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if(numbers.Contains(searchingNum))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    int minNumber = numbers.Dequeue();
                    while(numbers.Count>0)
                    {
                        int num = numbers.Dequeue();
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
}

