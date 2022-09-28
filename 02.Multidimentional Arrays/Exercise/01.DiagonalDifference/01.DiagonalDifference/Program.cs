using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for(int i=0; i<n; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }
            int primarySum = 0;
            int secondarySum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        primarySum += matrix[i, j];
                    }
                    if (i + j == n - 1)
                    {
                        secondarySum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine(Math.Abs(primarySum-secondarySum));
        }
    }
}

