using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car("VW", "MK3", 1992);

            Console.WriteLine($"{car.Make}: {car.Model}");
        }
    }
}

