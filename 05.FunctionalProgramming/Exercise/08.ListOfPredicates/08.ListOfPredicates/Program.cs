using System;
using System.Linq;

namespace _08.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for(int i=1; i<=n; i++)
            {
                for(int j=0; j<numbers.Length; j++)
                {
                    if (i % numbers[j]==0)
                    {

                    }
                    else
                    {

                    }
                }
            }
        }
    }
}

