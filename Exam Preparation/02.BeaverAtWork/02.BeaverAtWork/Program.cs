using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.BeaverAtWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<char> collectedBranches = new List<char>();
            char[,] matrix = new char[n, n];

            int colB = 0, rowB = 0;

            for(int i=0; i<n; i++)
            {
                char[] segments = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for(int j=0; j<n; j++)
                {
                    matrix[i, j] = segments[j];
                    if (matrix[i,j] == 'B')
                    {
                        colB = i;
                        rowB = j;
                    }
                }
            }

            string command;
            while((command = Console.ReadLine())!="end")
            {
                int previewCol = colB, previewRow = rowB;
                
                switch (command)
                {
                    case "up":
                        colB--;
                        if (colB < 0 || colB >= n || rowB<0 || rowB>=n)
                        {
                            if (collectedBranches.Count > 0)
                            {
                                collectedBranches.Remove(collectedBranches[collectedBranches.Count()-1]);
                            }
                        }
                        else
                        {
                            matrix[previewCol, previewRow] = '-';

                            if (char.IsLower(matrix[colB, rowB]))
                            {
                                collectedBranches.Add(matrix[colB, rowB]);
                            }
                            else if (matrix[colB, rowB] == 'F')
                            {
                                if (colB > 0)
                                {
                                    matrix[colB, rowB] = '-';
                                    if (char.IsLower(matrix[0, rowB]))
                                    {
                                        collectedBranches.Add(matrix[0, rowB]);
                                    }
                                    matrix[0, rowB] = 'B';
                                    colB = 0;
                                }
                                else
                                {
                                    matrix[colB, rowB] = '-';
                                    if (char.IsLower(matrix[n-1, rowB]))
                                    {
                                        collectedBranches.Add(matrix[n-1, rowB]);
                                    }
                                    matrix[n-1, rowB] = 'B';
                                    colB = n-1;
                                }
                            }
                        }
                        break;
                    case "down":
                        colB++;
                        if (colB < 0 || colB >= n || rowB < 0 || rowB >= n)
                        {
                            if (collectedBranches.Count > 0)
                            {
                                collectedBranches.Remove(collectedBranches[collectedBranches.Count()-1]);
                            }
                        }
                        else
                        {


                            matrix[previewCol, previewRow] = '-';
                            if (char.IsLower(matrix[colB, rowB]))
                            {
                                collectedBranches.Add(matrix[colB, rowB]);
                            }
                            else if (matrix[colB, rowB] == 'F')
                            {
                                if (colB < n)
                                {
                                    matrix[colB, rowB] = '-';
                                    if (char.IsLower(matrix[n, rowB]))
                                    {
                                        collectedBranches.Add(matrix[n-1, rowB]);
                                    }
                                    matrix[n-1, rowB] = 'B';
                                    colB = n-1;
                                }
                                else
                                {
                                    matrix[colB, rowB] = '-';
                                    if (char.IsLower(matrix[n-1, rowB]))
                                    {
                                        collectedBranches.Add(matrix[n-1, rowB]);
                                    }
                                    matrix[n-1, rowB] = 'B';
                                    colB = n-1;
                                }
                            }
                        }
                        break;
                    case "right":
                        rowB++;
                        if (colB < 0 || colB >= n || rowB < 0 || rowB >= n)
                        {
                            if (collectedBranches.Count > 0)
                            {
                                collectedBranches.Remove(collectedBranches[collectedBranches.Count()-1]);
                            }
                        }
                        else
                        {
                            matrix[previewCol, previewRow] = '-';
                            if (char.IsLower(matrix[colB, rowB]))
                            {
                                collectedBranches.Add(matrix[colB, rowB]);
                            }
                            else if (matrix[colB, rowB] == 'F')
                            {
                                if (rowB < n)
                                {
                                    matrix[colB, rowB] = '-';
                                    if (char.IsLower(matrix[colB, n-1]))
                                    {
                                        collectedBranches.Add(matrix[colB, n-1]);
                                    }
                                    matrix[colB, n-1] = 'B';
                                    rowB = n-1;
                                }
                            }
                        }
                        break;
                    case "left":
                        rowB--;
                        if (colB < 0 || colB >= n || rowB < 0 || rowB >= n)
                        {
                            if (collectedBranches.Count > 0)
                            {
                                collectedBranches.Remove(collectedBranches[collectedBranches.Count()-1]);
                            }
                        }
                        else
                        {
                            matrix[previewCol, previewRow] = '-';
                            if (char.IsLower(matrix[colB, rowB]))
                            {
                                collectedBranches.Add(matrix[colB, rowB]);
                            }
                            else if (matrix[colB, rowB] == 'F')
                            {
                                if (rowB > 0)
                                {
                                    matrix[colB, rowB] = '-';
                                    if (char.IsLower(matrix[colB, 0]))
                                    {
                                        collectedBranches.Add(matrix[colB, 0]);
                                    }
                                    matrix[colB, 0] = 'B';
                                    rowB = 0;
                                }
                            }
                        }
                        break;
                }
                
            }
            bool isCollected = true;
            int notCollected = 0;
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    if (char.IsLower(matrix[i,j]))
                    {
                        isCollected = false;
                        notCollected++;
                    }
                }
            }
            if (isCollected)
            {
                Console.WriteLine($"The Beaver successfully collect {collectedBranches.Count()} wood branches: {String.Join(", ", collectedBranches)}.");
            }
            else
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {notCollected} branches left.");
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}

