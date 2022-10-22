using System;
using System.Linq;

namespace _02.RallyRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            string carNumber = Console.ReadLine();
            int distance = 0;

            for(int i=0; i<n; i++)
            {
                char[] segments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for(int j=0; j<n; j++)
                {
                    matrix[i, j] = segments[j];
                }
            }
            int colC = 0, rowC = 0;
            string command = Console.ReadLine();
            while(true)
            {
                if(command=="End")
                {
                    Console.WriteLine($"Racing car {carNumber} DNF.");
                    Console.WriteLine($"Distance covered {distance} km.");
                    matrix[colC, rowC] = 'C';
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(matrix[i, j]);
                        }
                        Console.WriteLine();
                    }
                    return;
                }
                else if(command=="up")
                {
                    colC--;
                }
                else if(command=="down")
                {
                    colC++;
                }
                else if(command=="right")
                {
                    rowC++;
                }
                else if(command=="left")
                {
                    rowC--;
                }
                if (matrix[colC, rowC] == 'T')
                {
                    matrix[colC, rowC] = '.';
                    distance += 30;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (matrix[i, j] == 'T')
                            {
                                matrix[i, j] = '.';
                                colC = i;
                                rowC = j;
                                
                            }
                        }
                    }

                }
                else if (matrix[colC, rowC] == '.')
                {
                    distance += 10;
                }
                else
                {
                    distance += 10;
                    Console.WriteLine($"Racing car {carNumber} finished the stage!");
                    Console.WriteLine($"Distance covered {distance} km." );

                    matrix[colC, rowC] = 'C';
                    for(int i=0; i<n; i++)
                    {
                        for(int j=0; j<n; j++)
                        {
                            Console.Write(matrix[i,j]);
                        }
                        Console.WriteLine();
                    }
                    return;
                }

                command = Console.ReadLine();
            }
            
        }
    }
}

