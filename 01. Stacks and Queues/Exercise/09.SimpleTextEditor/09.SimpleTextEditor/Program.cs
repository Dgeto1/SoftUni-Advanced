using System;
using System.Collections.Generic;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOperations = int.Parse(Console.ReadLine());
            Stack<string> text = new Stack<string>();
            for(int i=1; i<=numberOperations;i++)
            {
                string[] segments = Console.ReadLine().Split();
                int command = int.Parse(segments[0]);
                if(command==1)
                {
                    text.Push(segments[1]);
                }
                else if(command==2)
                {
                    int count = int.Parse(segments[1]);
                    while(count>0)
                    {
                        text.Pop();
                        count--;
                    }
                }
                else if(command==3)
                {
                    int index = int.Parse(segments[1]);
                    int currentIndex = 1;
                    Stack<string> pom = new Stack<string>(text);
                    while(pom.Count>0)
                    {
                        if(index==currentIndex)
                        {
                            System.Console.WriteLine(pom.Pop());
                        }
                        else {
                            pom.Pop();
                            currentIndex++;
                        }
                    }
                    
                }
                else if(command==4)
                {
                    text.Pop();
                }
            }
        }
    }
}

