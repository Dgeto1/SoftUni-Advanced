    using System;
    using System.Collections.Generic;

    namespace _03.SimpleCalculator
    {
        class Program
        {
            static void Main(string[] args)
            {
                string[] expression = Console.ReadLine().Split();
                Array.Reverse(expression);
                int sum = 0;

                Stack<string> tokens = new Stack<string>(expression);
                sum += int.Parse(tokens.Pop());
                while (tokens.Count>0)
                {
                    char symbol = char.Parse(tokens.Pop());
                    if(symbol=='+')
                    {
                        sum += int.Parse(tokens.Pop());
                    }
                    else
                    {
                        sum -= int.Parse(tokens.Pop());
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }

