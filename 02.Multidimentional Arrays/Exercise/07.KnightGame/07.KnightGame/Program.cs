using System;
using System.Linq;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] chess = new char[n, n];

            for(int i=0; i<chess.GetLength(0); i++)
            {
                string values = Console.ReadLine();
                for(int j=0; j<chess.GetLength(1); j++)
                {
                    chess[i, j] = values[j];
                }
            }

        }
    }
}

