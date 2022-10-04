using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[sizes[0], sizes[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] values = Console.ReadLine().Split();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = values[j];
                }
            }
            string commands;

            while ((commands = Console.ReadLine()) != "END")
            {
                string[] segments = commands.Split();
                if (segments[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                }
                else if (segments.Length == 5)
                {
                    if (segments[0] != "swap" || int.Parse(segments[1]) >= matrix.GetLength(0) || int.Parse(segments[2]) >= matrix.GetLength(1) || int.Parse(segments[3]) >= matrix.GetLength(0) || int.Parse(segments[4]) >= matrix.GetLength(1))
                    {
                        Console.WriteLine("Invalid input!");
                    }

                    else
                    {
                        int row1 = int.Parse(segments[1]);
                        int col1 = int.Parse(segments[2]);
                        int row2 = int.Parse(segments[3]);
                        int col2 = int.Parse(segments[4]);
                        string swap = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = swap;
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write(String.Join(" ", matrix[i, j] + " "));
                            }
                            Console.WriteLine();

                        }
                    }


                }
            }
        }
    }
}