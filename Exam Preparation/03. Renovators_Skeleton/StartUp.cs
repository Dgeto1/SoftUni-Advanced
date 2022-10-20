using System;

namespace Renovators
{
    public class StartUp
    {
        static void Main()
        {
            // Initialize entity
            Renovator renovator = new Renovator("Gosho", "Painter", 270, 7);

            //Print Renovator
            Console.WriteLine(renovator);

            Console.Read();
        }
    }
}
