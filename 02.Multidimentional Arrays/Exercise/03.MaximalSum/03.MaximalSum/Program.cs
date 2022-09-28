using System;
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
            for(int i=0; i<matrix.GetLength(0)-2; i++)
            {
                for(int j=0; j<matrix.GetLength(1)-2; j++)
                {
                    int maxSum = 0;
                    
                }
            }
        }
    }
}

