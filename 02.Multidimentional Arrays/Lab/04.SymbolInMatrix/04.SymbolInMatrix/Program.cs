using System;
using System.Linq;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for(int i=0; i<n; i++)
            {
                string segments = Console.ReadLine();
                for(int j=0; j<n; j++)
                {
                    matrix[i, j] = segments[j];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            bool isFound = false;

            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n;j++)
                {
                    if (symbol == matrix[i,j])
                    {
                        Console.WriteLine($"({i}, {j})");
                        isFound = true;
                    }
                }
                if(isFound)
                {
                    break;
                }
            }
            if(!isFound)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}

