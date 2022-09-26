using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(", ");
            int rows = int.Parse(size[0]);
            int cols = int.Parse(size[1]);

            int[,] matrix = new int[rows, cols];
            int sum = 0;

            for(int i=0; i<rows;i++)
            {
                int[] segments = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for(int j=0; j < segments.Length;j++)
                {
                    matrix[i, j] = segments[j];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            for (int row = 0; row<rows;row++)
            {
                for(int col=0; col<cols; col++)
                {
                    sum += matrix[row, col];
                }
            }
            Console.WriteLine(sum);
        }
    }
}

