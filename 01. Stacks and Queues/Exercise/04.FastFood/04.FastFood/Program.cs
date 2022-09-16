using System;
using System.Collections.Generic;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            string[] sequence = Console.ReadLine().Split();
            Queue<int> orders = new Queue<int>();
            for (int i = 0; i < sequence.Length; i++)
            {
                orders.Enqueue(int.Parse(sequence[i]));
            }
            Queue<int> maxOrder = new Queue<int>(orders);
            int maxOrd = maxOrder.Dequeue();
            while (maxOrder.Count > 0)
            {
                int order = maxOrder.Dequeue();
                if (order > maxOrd)
                {
                    maxOrd = order;
                }
            }
            Console.WriteLine(maxOrd);
            while (orders.Count > 0)
            {
                int currentOrder = orders.Peek();
                if (currentOrder <= quantityFood)
                {
                    orders.Dequeue();
                    quantityFood -= currentOrder;
                }
                else
                {
                    Console.WriteLine($"Orders left: {String.Join(" ", orders)}");
                    return;
                }
            }
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}