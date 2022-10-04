using System;
using System.Linq;

namespace _05.SquareWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] values = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = values[j];
                }
            }
            int maxSum = int.MinValue;
            int[,] maxMatrix = new int[2, 2];

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxMatrix[0, 0] = matrix[i, j];
                        maxMatrix[0, 1] = matrix[i, j + 1];
                        maxMatrix[1, 0] = matrix[i + 1, j];
                        maxMatrix[1, 1] = matrix[i + 1, j + 1];
                    }
                }
            }
            for (int i = 0; i < maxMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < maxMatrix.GetLength(1); j++)
                {
                    Console.Write(String.Join(" ", maxMatrix[i,j]) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}

