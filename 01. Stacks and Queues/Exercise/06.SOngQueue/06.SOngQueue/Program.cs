using System;
using System.Collections.Generic;

namespace _06.SOngQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] segments = Console.ReadLine().Split(", ");
            Queue<string> songs = new Queue<string>(segments);

            while(songs.Count>0)
            {
                string[] commands = Console.ReadLine().Split();
                string command = commands[0];

                if(command=="Play")
                {
                    songs.Dequeue();
                }
                else if(command=="Add")
                {
                    string song = commands[1];
                    if(!songs.Contains(song))
                    {
                        songs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else
                {
                    Console.WriteLine(String.Join(", ", songs));
                }
            }
            if(songs.Count==0)
            {
                Console.WriteLine("No more songs!");
            }
        }
    }
}

