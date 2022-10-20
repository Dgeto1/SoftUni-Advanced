using System;
using System.Linq;

namespace _02.HelpAMole
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int collectdPoints = 0;

            int[,] matrix = new int[size, size];

            for(int i=0; i<size; i++)
            {
                string segments = Console.ReadLine();

                for(int j=0; j<size; j++)
                {
                    matrix[i, j] = segments[j];
                }
            }
            int colM = -1, rowM = -1;
            for(int i=0; i<size; i++)
            {
                for(int j=0; j<size; j++)
                {
                    if (matrix[i,j]=='M')
                    {
                        colM = i;
                        rowM = j;
                    }
                }
            }

            string command;
            while((command = Console.ReadLine())!="end")
            {
                switch (command)
                {
                    case "up":
                        if(colM+1>=size)
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }
                        else
                        {
                            if (matrix[colM + 1, rowM] == 'S')
                            {
                                matrix[colM, rowM] = '-';
                                matrix[colM + 1, rowM] = '-';
                                for(int i=0; i<size;i++)
                                {
                                    for(int j=0; j<size; j++)
                                    {
                                        if (matrix[i,j]=='S')
                                        {
                                            matrix[i, j] = 'M';
                                            colM = i;
                                            rowM = j;
                                            collectdPoints -= 3;
                                        }
                                    }
                                }
                            }
                            else if (matrix[colM+1, rowM]!= '-' || matrix[colM+1, rowM]!='S')
                            {
                                collectdPoints += int.Parse(matrix[colM + 1, rowM].ToString());
                                matrix[colM + 1, rowM] = '-';
                            }
                        }
                        
                        break;
                    case "down":
                        break;
                    case "right":
                        break;
                    case "left":
                        break;
                }
            }
        }
    }
}

