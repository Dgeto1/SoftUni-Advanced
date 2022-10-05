using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[sizes[0], sizes[1]];

            string snake = Console.ReadLine();

            int counter = 0;
            for(int i=0; i<matrix.GetLength(0); i++)
            {
                if(i%2!=0)
                {
                    for (int j = matrix.GetLength(1)-1; j >= 0; j--)
                    {
                        if(counter == snake.Length)
                        {
                            counter = 0;
                        }
                            matrix[i, j] = snake[counter].ToString();
                            counter++;
                    }
                }
                else
                {
                    for (int j = 0; j <matrix.GetLength(1); j++)
                    {
                        if (counter == snake.Length)
                        {
                            counter = 0;
                        }
                        matrix[i, j] = snake[counter].ToString();
                        counter++;
                    }
                }
            }
            for(int i=0; i<matrix.GetLength(0); i++)
            {
                for(int j=0; j<matrix.GetLength(1); j++)
                {
                    Console.Write(String.Join(" ", matrix[i,j]));
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}

