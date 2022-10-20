using System;
using System.Linq;

namespace _02.TruffleHunter
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int countWildBoar = 0, countBlack = 0, countWhite = 0, countSummer = 0;

            char[,] matrix = new char[size, size];

            for(int i=0; i<matrix.GetLength(0); i++)
            {
                char[] segments = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for(int j=0; j<matrix.GetLength(1); j++)
                {
                    matrix[i, j] = segments[j];
                }    
            }

            string commands;
            while((commands = Console.ReadLine())!="Stop the hunt")
            {
                string[] segments = commands.Split();
                string command = segments[0];
                int row = int.Parse(segments[1]);
                int col = int.Parse(segments[2]);

                switch(command)
                {
                    case "Collect":
                        if (matrix[row,col] != '-')
                        {
                            char currentPosition = matrix[row, col];
                            if(currentPosition=='B')
                            {
                                countBlack++;
                            }
                            else if(currentPosition=='W')
                            {
                                countWhite++;
                            }
                            else
                            {
                                countSummer++;
                            }
                            matrix[row, col] = '-';
                        }
                        break;
                    case "Wild_Boar":
                        string direction = segments[3];
                        switch(direction)
                        {
                            case "up":
                                for(int i=row; i>=0; i-=2)
                                {
                                    if (matrix[i,col] != '-')
                                    {
                                        countWildBoar++;
                                        matrix[i, col] = '-';
                                    }
                                }
                                break;
                            case "down":
                                for(int i = row; i<matrix.GetLength(0); i+=2)
                                {
                                    if (matrix[i, col] != '-')
                                    {
                                        countWildBoar++;
                                        matrix[i, col] = '-';
                                    }
                                }
                                break;
                            case "right":
                                for(int i=col; i<matrix.GetLength(1); i+=2)
                                {
                                    if (matrix[row, i] != '-')
                                    {
                                        countWildBoar++;
                                        matrix[row, i] = '-';
                                    }
                                }
                                break;
                            case "left":
                                for(int i=col; i>=0; i-=2)
                                {
                                    if (matrix[row, i] != '-')
                                    {
                                        countWildBoar++;
                                        matrix[row, i] = '-';
                                    }
                                }
                                break;
                        }
                        break;
                }
            }
            Console.WriteLine($"Peter manages to harvest {countBlack} black, {countSummer} summer, and {countWhite} white truffles.");
            Console.WriteLine($"The wild boar has eaten {countWildBoar} truffles.");
            for(int i=0; i<matrix.GetLength(0); i++)
            {
                for(int j=0; j<matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}

