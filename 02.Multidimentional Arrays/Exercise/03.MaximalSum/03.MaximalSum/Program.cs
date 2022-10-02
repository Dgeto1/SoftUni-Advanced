﻿using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for(int i=0; i<matrix.GetLength(0); i++)
            {
                int[] segmnets = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int j=0; j<matrix.GetLength(1); j++)
                {
                    matrix[i, j] = segmnets[j];
                }
            }
            int maxSum = int.MinValue;
            for(int i=0; i<matrix.GetLength(0)-2; i++)
            {
                for(int j=0; j<matrix.GetLength(1)-2; j++)
                {
                    int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                        matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                        matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if(currentSum>maxSum)
                    {
                        maxSum = currentSum;
                    }
                    
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}

