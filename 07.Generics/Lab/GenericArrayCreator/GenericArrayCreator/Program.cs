using System;

namespace GenericArrayCreator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] numbers = ArrayCreator.Create(10, 34);
            Console.Write(String.Join(",", numbers));
        }
    }
}

