using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.BeaverАtWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int countWood = 0;
            int rowB = -1, colB = -1;

            List<char> woods = new List<char>();

            char[,] matrix = new char[size, size];

            for(int i=0; i<size; i++)
            {
                char[] segments = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for(int j=0; j<size; j++)
                {
                    matrix[i, j] = segments[j];
                }
            }
            for(int i=0; i<size; i++)
            {
                for(int j=0; j<size; j++)
                {
                    if (matrix[i,j] == 'B')
                    {
                        rowB = i;
                        colB = j;
                    }
                }
            }

            string command;
            while((command = Console.ReadLine())!="end")
            {
                switch(command)
                {
                    case "up":
                        matrix[rowB, colB] = '-';
                        rowB++;
                        if (rowB > size)
                        {
                            woods.Remove(woods[woods.Count]);
                        }
                        else if (matrix[rowB, colB] == 'F')
                        {
                            matrix[rowB, colB] = '-';
                            if(rowB==0)
                            {
                                if (matrix[size, colB] != '-')
                                {
                                    countWood++;
                                    woods.Add(matrix[size, colB]);
                                }
                                matrix[size, colB] = 'B';
                            }
                            else
                            {
                                if (matrix[0, colB] != '-')
                                {
                                    countWood++;
                                    woods.Add(matrix[size, colB]);
                                }
                            }
                        }
                        else
                        {
                                if (matrix[rowB, colB] != '-')
                                {
                                    countWood++;
                                    woods.Add(matrix[size, colB]);
                                }
                            
                        }
                        break;
                    case "down":
                        matrix[rowB, colB] = '-';
                        rowB--;
                        if (rowB > size)
                        {
                            woods.Remove(woods[woods.Count]);
                        }
                        else if (matrix[rowB, colB] == 'F')
                        {
                            matrix[rowB, colB] = '-';
                            if (rowB == 0)
                            {
                                if (matrix[0, colB] != '-')
                                {
                                    countWood++;
                                    woods.Add(matrix[0, colB]);
                                }
                                matrix[0, colB] = 'B';
                            }
                            else
                            {
                                if (matrix[size, colB] != '-')
                                {
                                    countWood++;
                                    woods.Add(matrix[size, colB]);
                                }
                            }
                        }
                        else
                        {
                                if (matrix[rowB, colB] != '-')
                                {
                                    countWood++;
                                    woods.Add(matrix[size, colB]);
                                }
                        }
                        break;
                    case "right":
                        matrix[rowB, colB] = '-';
                        colB++;
                        if (colB > size)
                        {
                            woods.Remove(woods[woods.Count]);
                        }
                        else if (matrix[rowB, colB] == 'F')
                        {
                            matrix[rowB, colB] = '-';
                            if (colB == 0)
                            {
                                if (matrix[rowB, size] != '-')
                                {
                                    countWood++;
                                    woods.Add(matrix[rowB, size]);
                                }
                                matrix[rowB, size] = 'B';
                            }
                            else
                            {
                                if (matrix[rowB, size] != '-')
                                {
                                    countWood++;
                                    woods.Add(matrix[rowB, size]);
                                }
                            }
                        }
                        else
                        {
                                if (matrix[rowB, colB] != '-')
                                {
                                    countWood++;
                                    woods.Add(matrix[rowB, colB]);
                                }
                        }
                       break;
                    case "left":
                        matrix[rowB, colB] = '-';
                        colB--;
                        if (colB > size || colB < 0)
                        {
                            woods.Remove(woods[woods.Count]);
                        }
                        else if (matrix[rowB, colB] == 'F')
                        {
                            matrix[rowB, colB] = '-';
                            if (colB == 0)
                            {
                                if (matrix[rowB, 0] != '-')
                                {
                                    countWood++;
                                    woods.Add(matrix[rowB, 0]);
                                }
                                matrix[rowB, 0] = 'B';
                            }
                            else
                            {
                                if (matrix[rowB, 0] != '-')
                                {
                                    countWood++;
                                    woods.Add(matrix[rowB, 0]);
                                }
                            }
                        }
                        else
                        {
                                if (matrix[rowB, colB] != '-')
                                {
                                    countWood++;
                                    woods.Add(matrix[rowB, colB]);
                                }
                        }
                        break;
                }
            }
            int countNotCollected = 0;
            for(int i=0; i<size; i++)
            {
                for(int j=0; j<size; j++)
                {
                    if (matrix[i,j] != '-' || matrix[i,j] != 'B' || matrix[i,j] != 'F')
                    {
                        countNotCollected++;
                    }
                }
            }
            if(countNotCollected>0)
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {countNotCollected} branches left.");
            }
            else
            {
                Console.WriteLine($"The Beaver successfully collect {woods.Count} wood branches: {String.Join(", ", woods)}");
            }
            Console.Read();
        }
    }
}

