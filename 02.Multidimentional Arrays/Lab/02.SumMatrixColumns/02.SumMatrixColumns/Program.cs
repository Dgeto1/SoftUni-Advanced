using System;
using System.Linq;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sizes = Console.ReadLine().Split(", ");
            int rows = int.Parse(sizes[0]);
            int columns = int.Parse(sizes[1]);

            int[,] matrix = new int[rows, columns];

            for(int i=0; i<rows; i++)
            {
                int[] values = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for(int j=0; j<columns;j++)
                {
                    matrix[i, j] = values[j];
                }
            }
            for(int i=0; i<matrix.GetLength(1); i++)
            {
                int sum = 0;
                for (int j=0; j<matrix.GetLength(0); j++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine(sum);
            }    
        }
    }
}

