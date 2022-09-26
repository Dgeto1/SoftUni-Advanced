using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeMatrix, sizeMatrix];

            for(int i=0; i<sizeMatrix; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int j=0; j<sizeMatrix; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }
            int sum = 0;

            for(int i=0; i<sizeMatrix; i++)
            {
                for(int j=0; j<sizeMatrix; j++)
                {
                    if(i==j)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}

